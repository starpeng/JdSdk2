﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoTraceJosService
{
﻿    [Serializable]
    public class WaybillMissingJosResult : JdObject
    {
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("resultType")]
        public Nullable<Int32> ResultType
        {
            get;
            set;
        }

        [JsonProperty("waybillMissingDtoList")]
        public List<WaybillMissingDto> WaybillMissingDtoList
        {
            get;
            set;
        }

    }

}
