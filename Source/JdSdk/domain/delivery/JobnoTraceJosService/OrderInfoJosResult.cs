﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoTraceJosService
{
﻿    [Serializable]
    public class OrderInfoJosResult : JdObject
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

        [JsonProperty("orderInfoDto")]
        public OrderInfoDto OrderInfoDto
        {
            get;
            set;
        }

    }

}
