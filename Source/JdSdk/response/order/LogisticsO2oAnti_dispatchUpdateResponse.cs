﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Order.StoreOFCService;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class LogisticsO2oAntiDispatchUpdateResponse : JdResponse
    {
        [JsonProperty("OrderServiceResponse")]
        public OrderServiceResponse OrderServiceResponse
        {
            get;
            set;
        }

    }

}
