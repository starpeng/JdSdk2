using System;
using System.Runtime.Serialization;

namespace JdSdk
{
    /// <summary>
    /// Jd客户端异常。
    /// </summary>
    public class JdException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public JdException()
            : base()
        {
        }

        public JdException(string message)
            : base(message)
        {
        }

        protected JdException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public JdException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public JdException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
