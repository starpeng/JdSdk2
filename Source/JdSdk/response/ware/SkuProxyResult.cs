﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class SkuProxyResult : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("item_id")]
        public Nullable<Int64> ItemId
        {
            get;
            set;
        }

        [JsonProperty("seller_id")]
        public Nullable<Int64> SellerId
        {
            get;
            set;
        }

        [JsonProperty("sku_status")]
        public Nullable<Int32> SkuStatus
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

        [JsonProperty("market_price")]
        public Nullable<Decimal> MarketPrice
        {
            get;
            set;
        }

        [JsonProperty("sell_price")]
        public Nullable<Decimal> SellPrice
        {
            get;
            set;
        }

        [JsonProperty("cost_price")]
        public Nullable<Decimal> CostPrice
        {
            get;
            set;
        }

        [JsonProperty("stock_num")]
        public Nullable<Int32> StockNum
        {
            get;
            set;
        }

        [JsonProperty("occupied_inventory")]
        public Nullable<Int32> OccupiedInventory
        {
            get;
            set;
        }

        [JsonProperty("usable_inventory")]
        public Nullable<Int32> UsableInventory
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }

}
