
using System;

namespace JdSdk.Request
{
    /// <summary>
    /// Jd请求接口。
    /// </summary>
    public interface IJdRequest<T> where T : JdResponse
    {
        /// <summary>
        /// 获取Jd的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        String ApiName
        {
            get;
        }

        String GetParamJson();

        /// <summary>
        /// 提前验证参数。
        /// </summary>
        void Validate();
    }
}
