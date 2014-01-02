using System;

namespace JdSdk
{
    /// <summary>
    /// 请求验证器。
    /// </summary>
    public sealed class RequestValidator
    {
        private const String ERR_CODE_PARAM_MISSING = "40";
        private const String ERR_CODE_PARAM_INVALID = "41";
        private const String ERR_MSG_PARAM_MISSING = "验证错误(JdSdk):缺少必须的参数:{0}";
        private const String ERR_MSG_PARAM_INVALID = "验证错误(JdSdk):无效的参数:{0}";

        /// <summary>
        /// 验证参数是否为空。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        public static void ValidateRequired(String name, Object value)
        {
            if (value == null)
            {
                throw new JdException(ERR_CODE_PARAM_MISSING, String.Format(ERR_MSG_PARAM_MISSING, name));
            }
            else
            {
                if (value.GetType() == typeof(String))
                {
                    String strValue = value as String;
                    if (String.IsNullOrEmpty(strValue))
                    {
                        throw new JdException(ERR_CODE_PARAM_MISSING, String.Format(ERR_MSG_PARAM_MISSING, name));
                    }
                }
            }
        }

        /// <summary>
        /// 验证字符串参数的最大长度。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="maxLength">最大长度</param>
        public static void ValidateMaxLength(String name, String value, int maxLength)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
            }
        }

        /// <summary>
        /// 验证上传文件的最大字节长度。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="maxLength">最大长度</param>
        public static void ValidateMaxLength(String name, FileItem value, int maxLength)
        {
            if (value != null && value.GetContent() != null && value.GetContent().Length > maxLength)
            {
                throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
            }
        }

        /// <summary>
        /// 验证以逗号分隔的字符串参数的最大列表长度。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="maxSize">最大列表长度</param>
        public static void ValidateMaxListSize(String name, String value, int maxSize)
        {
            if (value != null)
            {
                String[] data = value.Split(',');
                if (data != null && data.Length > maxSize)
                {
                    throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
                }
            }
        }

        /// <summary>
        /// 验证字符串参数的最小长度。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="minLength">最小长度</param>
        public static void ValidateMinLength(String name, String value, int minLength)
        {
            if (value != null && value.Length < minLength)
            {
                throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
            }
        }

        /// <summary>
        /// 验证数字参数的最大值。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="maxValue">最大值</param>
        public static void ValidateMaxValue(String name, Nullable<long> value, long maxValue)
        {
            if (value != null && value > maxValue)
            {
                throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
            }
        }

        /// <summary>
        /// 验证数字参数的最小值。
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="minValue">最小值</param>
        public static void ValidateMinValue(String name, Nullable<long> value, long minValue)
        {
            if (value != null && value < minValue)
            {
                throw new JdException(ERR_CODE_PARAM_INVALID, String.Format(ERR_MSG_PARAM_INVALID, name));
            }
        }
    }
}
