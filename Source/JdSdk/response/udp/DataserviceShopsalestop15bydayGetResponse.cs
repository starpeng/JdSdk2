﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Udp.ShopSalesTop15Interface;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShopsalestop15bydayGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopSalesTop15ResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
