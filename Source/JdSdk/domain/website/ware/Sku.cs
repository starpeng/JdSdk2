﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Ware
{
﻿    [Serializable]
    public class Sku : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("stock_num")]
        public String StockNum
        {
            get;
            set;
        }

        [JsonProperty("color")]
        public String Color
        {
            get;
            set;
        }

        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

    }

}
