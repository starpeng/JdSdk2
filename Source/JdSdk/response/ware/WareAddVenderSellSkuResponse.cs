﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareAddVenderSellSkuResponse : JdResponse
    {
        [JsonProperty("wareaddvender_sellsku")]
        public WareAddVenderSellSkuRequest WareAddVenderSellSkuRequest
        {
            get;
            set;
        }

    }

}
