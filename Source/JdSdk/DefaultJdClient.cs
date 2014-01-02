using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;
using JdSdk.Parser;
using JdSdk.Request;
using Newtonsoft.Json.Linq;

namespace JdSdk
{
    /// <summary>
    /// 基于REST的Jd客户端。
    /// </summary>
    public class DefaultJdClient : IJdClient
    {
        public const string APP_KEY = "app_key";
        public const string APP_PARAM = "360buy_param_json";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "v";
        public const string SIGN = "sign";
        //public const string PARTNER_ID = "partner_id";
        public const string ACCESSTOKEN = "access_token";
        public const string FORMAT_XML = "xml";
        public const string FORMAT_JSON = "json";

        private string serverUrl;
        private string appKey;
        private string appSecret;
        private string accessToken;
        private string format = FORMAT_JSON;

        private WebUtils webUtils;
        private IJdLogger topLogger;

        private bool disableParser = false; // 禁用响应结果解释
        private bool disableTrace = true; // 禁用日志调试功能

        #region DefaultJdClient Constructors

        public DefaultJdClient(string serverUrl, string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
            this.topLogger = new DefaultJdLogger();
        }

        public DefaultJdClient(string serverUrl, string appKey, string appSecret, string sessionkey)
            : this(serverUrl, appKey, appSecret)
        {
            this.accessToken = sessionkey;
        }

        #endregion

        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetJdLogger(IJdLogger topLogger)
        {
            this.topLogger = topLogger;
        }

        public void SetAccessToken(String accessToken)
        {
            this.accessToken = accessToken;
        }

        #region IJdClient Members

        public T Execute<T>(IJdRequest<T> request) where T : JdResponse
        {
            return Execute<T>(request, accessToken);
        }

        public T Execute<T>(IJdRequest<T> request, string accessToken) where T : JdResponse
        {
            return Execute<T>(request, accessToken, DateTime.Now);
        }

        private T Execute<T>(IJdRequest<T> request, string accessToken, DateTime timestamp) where T : JdResponse
        {
            if (disableTrace)
            {
                return DoExecute<T>(request, accessToken, timestamp);
            }
            else
            {
                try
                {
                    return DoExecute<T>(request, accessToken, timestamp);
                }
                catch (Exception e)
                {
                    topLogger.Error(this.serverUrl + "\r\n" + e.StackTrace);
                    throw e;
                }
            }
        }

        #endregion

        public string GetParamJson(IDictionary<string, string> parameters)
        {
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();
            StringBuilder query = new StringBuilder("{");
            Boolean first = true;
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key))
                {
                    Trace.WriteLine(String.Format("参数：{0}  值：{1}", key, value));
                    if (!first)
                        query.Append(",");

                    query.AppendFormat("\"{0}\":\"{1}\"", key, value);
                    first = false;
                }
            }

            query.Append("}");
            return query.ToString();
        }

        private T DoExecute<T>(IJdRequest<T> request, string accessToken, DateTime timestamp) where T : JdResponse
        {
            //if (String.IsNullOrEmpty(accessToken))
            //{
            //    throw new Exception("Access Token 必须提供！");
            //}

            // 提前检查业务参数
            try
            {
                request.Validate();
            }
            catch (JdException e)
            {
                return createErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
            }

            // 添加协议级请求参数
            JdDictionary txtParams = new JdDictionary();
            txtParams.Add(APP_PARAM, request.GetParamJson());
            txtParams.Add(METHOD, request.ApiName);
            txtParams.Add(VERSION, "2.0");
            txtParams.Add(APP_KEY, appKey);
            //txtParams.Add(FORMAT, format);
            //txtParams.Add(PARTNER_ID, "top-sdk-net-20111024");
            txtParams.Add(TIMESTAMP, timestamp);
            txtParams.Add(ACCESSTOKEN, accessToken);

            // 添加签名参数
            txtParams.Add(SIGN, JdUtils.SignJdRequest(txtParams, appSecret));

            // 是否需要上传文件
            string body;
            if (request is IJdUploadRequest<T>)
            {
                IJdUploadRequest<T> uRequest = (IJdUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = JdUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl, txtParams, fileParams);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl, txtParams);
            }

            // 解释响应结果
            T rsp;
            if (disableParser)
            {
                rsp = Activator.CreateInstance<T>();
                rsp.Body = body;
            }
            else
            {
                if (FORMAT_JSON.Equals(format))
                {
                    IJdParser<T> tp = new JdJsonParser<T>();
                    rsp = tp.Parse(body);
                }
                else
                {
                    IJdParser<T> tp = new JdXmlParser<T>();
                    rsp = tp.Parse(body);
                }
            }

            // 追踪错误的请求
            if (!disableTrace)
            {
                rsp.ReqUrl = webUtils.BuildGetUrl(this.serverUrl, txtParams);
                if (rsp.IsError)
                {
                    topLogger.Warn(rsp.ReqUrl + "\r\n" + rsp.Body);
                }
            }

            return rsp;
        }

        private T createErrorResponse<T>(string errCode, string errMsg) where T : JdResponse
        {
            T rsp = Activator.CreateInstance<T>();
            rsp.ErrCode = errCode;
            rsp.ErrMsg = errMsg;

            if (FORMAT_XML.Equals(format))
            {
                XmlDocument root = new XmlDocument();
                XmlElement bodyE = root.CreateElement("error_response");
                XmlElement codeE = root.CreateElement("code");
                codeE.InnerText = errCode;
                bodyE.AppendChild(codeE);
                XmlElement msgE = root.CreateElement("msg");
                msgE.InnerText = errMsg;
                bodyE.AppendChild(msgE);
                root.AppendChild(bodyE);
                rsp.Body = root.OuterXml;
            }
            else
            {
                JObject errJson = new JObject();
                errJson["error_response"] = new JObject();
                errJson["error_response"]["code"] = errCode;
                errJson["error_response"]["zh_desc"] = errMsg;
                string body = errJson.ToString();
                rsp.Body = body;
            }

            return rsp;
        }
    }
}
