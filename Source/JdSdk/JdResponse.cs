using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JdSdk
{
    /// <summary>
    /// 京东接口返回数据
    /// </summary>
    [Serializable]
    public abstract class JdResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code")]
        public String ErrCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public String ErrMsg
        {
            get
            {
                return String.Concat(EnErrMsg, ZhErrMsg);
            }

            internal set
            {
                this.ZhErrMsg = value;
            }
        }

        [XmlElement("zh_desc")]
        [JsonProperty("zh_desc")]
        public String ZhErrMsg { get; set; }

        /// <summary>
        /// 英文错误信息
        /// </summary>
        [XmlElement("en_desc")]
        [JsonProperty("en_desc")]
        public String EnErrMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public String Body { get; set; }


        /// <summary>
        /// 响应的JSON object
        /// </summary>
        public JObject Json { get; set; }


        /// <summary>
        /// HTTP GET请求的URL
        /// </summary>
        public String ReqUrl { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public virtual Boolean IsError
        {
            get
            {
                return (!string.IsNullOrEmpty(this.ErrCode)
                    && !String.Equals(this.ErrCode, "0", StringComparison.InvariantCultureIgnoreCase)
                    )
                    || !string.IsNullOrEmpty(this.ErrMsg);
            }
        }
    }
}
