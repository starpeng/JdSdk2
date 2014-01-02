﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class PriceChange : JdObject
    {
        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
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

    }

}
