﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoStatusJosService
{
﻿    [Serializable]
    public class OrderSignJosResult : JdObject
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

        [JsonProperty("orderSignDtoList")]
        public List<OrderSignDto> OrderSignDtoList
        {
            get;
            set;
        }

    }

}
