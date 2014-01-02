using JdSdk.Request;

namespace JdSdk
{
    /// <summary>
    /// Jd客户端。
    /// </summary>
    public interface IJdClient
    {
        /// <summary>
        /// 执行Jd公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Jd API请求</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IJdRequest<T> request) where T : JdResponse;

        ///// <summary>
        ///// 执行Jd隐私API请求。
        ///// </summary>
        ///// <typeparam name="T">领域对象</typeparam>
        ///// <param name="request">具体的Jd API请求</param>
        ///// <param name="session">用户会话码</param>
        ///// <returns>领域对象</returns>
        //T Execute<T>(IJdRequest<T> request, string session) where T : JdResponse;

        ///// <summary>
        ///// 执行Jd隐私API请求。
        ///// </summary>
        ///// <typeparam name="T">领域对象</typeparam>
        ///// <param name="request">具体的Jd API请求</param>
        ///// <param name="session">用户会话码</param>
        ///// <param name="timestamp">请求时间戳</param>
        ///// <returns>领域对象</returns>
        //T Execute<T>(IJdRequest<T> request, string session, DateTime timestamp) where T : JdResponse;
    }
}
