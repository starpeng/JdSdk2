using System;
using Newtonsoft.Json;

namespace JdSdk
{
    /// <summary>
    /// 访问令牌
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonProperty("access_token")]
        public String Token
        {
            get;
            internal set;
        }

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("code")]
        public String Code
        {
            get;
            internal set;
        }

        /// <summary>
        /// 失效时间（秒）
        /// </summary>
        [JsonProperty("expires_in")]
        public Int32 ExpiresIn
        {
            get;
            internal set;
        }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [JsonProperty("refresh_token")]
        public String RefreshToken
        {
            get;
            internal set;
        }

        /// <summary>
        /// 在此时间内允许重置token（毫秒）
        /// </summary>
        [JsonProperty("time")]
        public String Time
        {
            get;
            internal set;
        }

        /// <summary>
        /// 令牌类型
        /// </summary>
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
        /// 授权用户对应的京东ID
        /// </summary>
        [JsonProperty("uid")]
        public String Uid { get; set; }

        /// <summary>
        /// 授权用户对应的京东昵称
        /// </summary>
        [JsonProperty("user_nick")]
        public String UserNick { get; set; }

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
