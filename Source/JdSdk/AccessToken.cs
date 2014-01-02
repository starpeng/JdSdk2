using System;
using Newtonsoft.Json;

namespace JdSdk
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessToken
    {
        [JsonProperty("access_token")]
        public String Token
        {
            get;
            internal set;
        }

        [JsonProperty("code")]
        public String Code
        {
            get;
            internal set;
        }


        [JsonProperty("expires_in")]
        public Int32 ExpiresIn
        {
            get;
            internal set;
        }

        [JsonProperty("refresh_token")]
        public String RefreshToken
        {
            get;
            internal set;
        }

        [JsonProperty("time")]
        public String Time
        {
            get;
            internal set;
        }

        [JsonProperty("token_type")]
        public String TokenType
        {
            get;
            internal set;
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("error_description")]
        public String ErrorMessage
        {
            get;
            internal set;
        }

        /// <summary>
        /// 创建时间，获取的时间
        /// </summary>
        public DateTime CreateTime
        {
            get;
            internal set;
        }
    }

    /// <summary>
    /// 授权类型
    /// </summary>
    public enum GrantType
    {
        /// <summary>
        /// 认证代码
        /// </summary>
        AuthorizationCode,

        /// <summary>
        /// 帐号密码
        /// </summary>
        Password,

        /// <summary>
        /// 刷新标记
        /// </summary>
        RefreshToken
    }
}
