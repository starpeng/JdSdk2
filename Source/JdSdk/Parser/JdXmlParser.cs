using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace JdSdk.Parser
{
    /// <summary>
    /// Jd XML响应通用解释器。
    /// </summary>
    public class JdXmlParser<T> : IJdParser<T> where T : JdResponse
    {
        private static Regex regex = new Regex("<(\\w+?)[ >]", RegexOptions.Compiled);
        private static Dictionary<string, XmlSerializer> parsers = new Dictionary<string, XmlSerializer>();

        #region IJdParser<T> Members

        public T Parse(string body)
        {
            XmlSerializer serializer = null;
            string rootTagName = GetRootElement(body);

            bool inc = parsers.TryGetValue(rootTagName, out serializer);
            if (!inc || serializer == null)
            {
                XmlAttributes rootAttrs = new XmlAttributes();
                rootAttrs.XmlRoot = new XmlRootAttribute(rootTagName);

                XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
                attrOvrs.Add(typeof(T), rootAttrs);

                serializer = new XmlSerializer(typeof(T), attrOvrs);
                parsers[rootTagName] = serializer;
            }

            object obj = null;
            using (Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(body)))
            {
                obj = serializer.Deserialize(stream);
            }

            T rsp = (T)obj;
            if (rsp != null)
            {
                rsp.Body = body;
            }
            return rsp;
        }

        #endregion

        /// <summary>
        /// 获取XML响应的根节点名称
        /// </summary>
        private string GetRootElement(string body)
        {
            Match match = regex.Match(body);
            if (match.Success)
            {
                return match.Groups[1].ToString();
            }
            else
            {
                throw new JdException("Invalid XML response format!");
            }
        }
    }
}
