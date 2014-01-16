﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Udp.ShopVisTop15Interface;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShopvistop15byweekGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopVistResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
