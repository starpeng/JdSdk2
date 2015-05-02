using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JdSdk.Parser
{
    /// <summary>
    /// Jd JSON响应通用解释器。
    /// </summary>
    public class JdJsonParser<T> : IJdParser<T> where T : JdResponse
    {
        public T Parse(string body)
        {
            var isUnionQueryOrders = body.StartsWith("{\"jingdong_UnionOrderService_queryOrders_responce");
            var isUnionGetCode = body.StartsWith("{\"jingdong_service_promotion_getcode_responce");
            T rsp = null;
            JObject json = JObject.Parse(body);
            if (json != null && json.First != null)
            {
             
                if (isUnionQueryOrders)
                {
                    var dataStr = json["jingdong_UnionOrderService_queryOrders_responce"]["queryorders_result"];
                    var data = JObject.Parse(dataStr.ToString());
                    rsp = data.ToObject<T>(GetJsonSerializer());
                }
                else if (isUnionGetCode)
                {
                    var dataStr = json["jingdong_service_promotion_getcode_responce"]["queryjs_result"];
                    var data = JObject.Parse(dataStr.ToString());
                    rsp = data.ToObject<T>(GetJsonSerializer());
                }
                else
                {
                    var data = (JObject) json.First.First;
                   
                    if (data != null)
                    {
                        rsp = data.ToObject<T>(GetJsonSerializer());
                    }
                }

            }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
                rsp.Json = json;
            }

            return rsp;
        }

        private static JsonSerializer _jsonSerializer = null;
        public static JsonSerializer GetJsonSerializer()
        {
            if (_jsonSerializer == null)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.Converters = new List<JsonConverter>(JdUtils.GetJsonConverters());
                _jsonSerializer = JsonSerializer.Create(settings);
            }

            return _jsonSerializer;
        }

    }
}
