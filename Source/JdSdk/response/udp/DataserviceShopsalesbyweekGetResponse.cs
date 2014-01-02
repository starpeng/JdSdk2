﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShopsalesbyweekGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopSalesResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
