﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareUpdateVenderSellSkuResponse : JdResponse
    {
        [JsonProperty("wareupdatevender_sellsku")]
        public WareUpdateVenderSellSkuRequest WareupdateVenderSellSkuRequest
        {
            get;
            set;
        }

    }

}
