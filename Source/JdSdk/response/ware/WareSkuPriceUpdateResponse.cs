﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareSkuPriceUpdateResponse : JdResponse
    {
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

    }

}
