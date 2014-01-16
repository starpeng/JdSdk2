﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Udp.ShopVolTop15Interface;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShopvoltop15byweekGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopVolResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
