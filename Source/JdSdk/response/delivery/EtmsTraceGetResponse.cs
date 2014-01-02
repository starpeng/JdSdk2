﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsTraceGetResponse : JdResponse
    {
        [JsonProperty("trace_api_dtos")]
        public List<TraceApiDto> TraceApiDtos
        {
            get;
            set;
        }

    }

}
