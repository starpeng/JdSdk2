using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace JdSdk
{
    /// <summary>
    /// Td系统工具类。
    /// </summary>
    public abstract class JdUtils
    {
        private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// 格式化日期
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static String FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString(DATE_TIME_FORMAT, System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// 给Jd请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的Jd请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string SignJdRequest(IDictionary<string, string> parameters, string secret)
        {
            return SignJdRequest(parameters, secret, true);
        }

        /// <summary>
        /// 给Jd请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的Jd请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <param name="qhs">是否前后都加密钥进行签名</param>
        /// <returns>签名</returns>
        public static string SignJdRequest(IDictionary<string, string> parameters, string secret, bool qhs)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }
            if (qhs)
            {
                query.Append(secret);
            }

            // 第三步：使用MD5加密
            MD5 md5 = MD5.Create();
            Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string hex = bytes[i].ToString("X");
                if (hex.Length == 1)
                {
                    result.Append("0");
                }
                result.Append(hex.ToUpper());
            }

            return result.ToString();
        }

        /// <summary>
        /// 解释Jd回调参数为键值对（采用GBK字符集编码）。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeJdParams(string topParams)
        {
            return DecodeJdParams(topParams, Encoding.GetEncoding("GBK"));
        }

        /// <summary>
        /// 解释Jd回调参数为键值对。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <param name="encoding">字符集编码</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeJdParams(string topParams, Encoding encoding)
        {
            if (string.IsNullOrEmpty(topParams))
            {
                return null;
            }
            Byte[] buffer = Convert.FromBase64String(Uri.UnescapeDataString(topParams));
            string originJdParams = encoding.GetString(buffer);
            return SplitUrlQuery(originJdParams);
        }

        /// <summary>
        /// 拆分Url Query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static IDictionary<string, string> SplitUrlQuery(string query)
        {
            IDictionary<string, string> result = new Dictionary<string, string>();

            string[] pairs = query.Split(new char[] { '&' });
            if (pairs != null && pairs.Length > 0)
            {
                foreach (string pair in pairs)
                {
                    string[] oneParam = pair.Split(new char[] { '=' }, 2);
                    if (oneParam != null && oneParam.Length == 2)
                    {
                        result.Add(oneParam[0], oneParam[1]);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dict)
        {
            IDictionary<string, T> newDict = new Dictionary<string, T>(dict.Count);
            IEnumerator<KeyValuePair<string, T>> dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                T value = dem.Current.Value;
                if (value != null)
                {
                    newDict.Add(name, value);
                }
            }

            return newDict;
        }

        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(Byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }
            else if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }
            else if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }
            else if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(Byte[] fileData)
        {
            string suffix = GetFileSuffix(fileData);
            string mimeType;

            switch (suffix)
            {
                case "JPG": mimeType = "image/jpeg"; break;
                case "GIF": mimeType = "image/gif"; break;
                case "PNG": mimeType = "image/png"; break;
                case "BMP": mimeType = "image/bmp"; break;
                default: mimeType = "application/octet-stream"; break;
            }

            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) || fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }

        /// <summary>
        /// 获取JsonConverter
        /// </summary>
        /// <returns></returns>
        public static JsonConverter[] GetJsonConverters()
        {
            List<JsonConverter> list = new List<JsonConverter> { new DateTimeConverter() };
            return list.ToArray();
        }
    }
}
