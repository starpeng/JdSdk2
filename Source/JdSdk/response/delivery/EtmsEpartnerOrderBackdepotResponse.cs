﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Delivery.JobnoStatusJosService;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsEpartnerOrderBackdepotResponse : JdResponse
    {
        [JsonProperty("orderBackDepotResult")]
        public OrderBackDepotResult OrderBackDepotResult
        {
            get;
            set;
        }

    }

}
