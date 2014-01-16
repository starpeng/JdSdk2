﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Delivery.JobnoStatusJosService;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsEpartnerOrderBackstationResponse : JdResponse
    {
        [JsonProperty("orderBackStationResult")]
        public OrderBackStationResult OrderBackStationResult
        {
            get;
            set;
        }

    }

}
