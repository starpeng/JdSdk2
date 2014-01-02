﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Delivery;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class DeliveryLogisticsGetResponse : JdResponse
    {
        [JsonProperty("logistics_companies")]
        public LogisticsCompanies LogisticsCompanies
        {
            get;
            set;
        }

    }

}
