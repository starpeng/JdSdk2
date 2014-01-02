using System;
using System.Diagnostics;
using System.IO;

namespace JdSdk
{
    /// <summary>
    /// 日志打点的简单实现。
    /// </summary>
    public class DefaultJdLogger : IJdLogger
    {
        public const string LOG_FILE_NAME = "jdsdk.log";
        public const string DATETIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        static DefaultJdLogger()
        {
            FileInfo logFile = new FileInfo(LOG_FILE_NAME);
            if (logFile.Exists)
            {
                DateTime created = logFile.CreationTime;

                if (created.DayOfYear != DateTime.Now.DayOfYear)
                {
                    string archiveFileName = LOG_FILE_NAME + "." + created.ToString("yyyyMMdd");
                    FileInfo archiveFile = new FileInfo(archiveFileName);
                    if (!archiveFile.Exists)
                    {
                        logFile.MoveTo(archiveFileName);
                    }
                }
            }

            Trace.Listeners.Add(new TextWriterTraceListener(LOG_FILE_NAME));
            Trace.AutoFlush = true;
        }

        public void Error(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " ERROR");
        }

        public void Warn(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " WARN");
        }

        public void Info(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " INFO");
        }
    }
}
