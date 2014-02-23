﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Ware
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

        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        [JsonProperty("cost_price")]
        public String CostPrice
        {
            get;
            set;
        }

        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        [JsonProperty("stock_num")]
        public Nullable<Int64> StockNum
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

        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("color_value")]
        public String ColorValue
        {
            get;
            set;
        }

        [JsonProperty("size_value")]
        public String SizeValue
        {
            get;
            set;
        }

    }

}
