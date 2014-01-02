
namespace JdSdk
{
    /// <summary>
    /// 日志打点接口。
    /// </summary>
    public interface IJdLogger
    {
        void Error(string message);
        void Warn(string message);
        void Info(string message);
    }
}
