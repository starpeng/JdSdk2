﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareInfoByInfoSearchResponse : JdResponse
    {
        [JsonProperty("ware_infos")]
        public List<JdSdk.Domain.Ware.Ware> WareInfos
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

﻿        [Serializable]
        public class WareInfo : JdObject
        {
            [JsonProperty("ware_id")]
            public Nullable<Int64> WareId
            {
                get;
                set;
            }

            [JsonProperty("spu_id")]
            public Nullable<Int64> SpuId
            {
                get;
                set;
            }

            [JsonProperty("category_id")]
            public Nullable<Int64> CategoryId
            {
                get;
                set;
            }

            [JsonProperty("vender_id")]
            public Nullable<Int64> VenderId
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

            [JsonProperty("ware_status")]
            public String WareStatus
            {
                get;
                set;
            }

            [JsonProperty("title")]
            public String Title
            {
                get;
                set;
            }

            [JsonProperty("item_num")]
            public String ItemNum
            {
                get;
                set;
            }

            [JsonProperty("upc_code")]
            public String UpcCode
            {
                get;
                set;
            }

            [JsonProperty("transport_id")]
            public Nullable<Int64> TransportId
            {
                get;
                set;
            }

            [JsonProperty("online_time")]
            public String OnlineTime
            {
                get;
                set;
            }

            [JsonProperty("offline_time")]
            public String OfflineTime
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

            [JsonProperty("jd_price")]
            public String JdPrice
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

            [JsonProperty("logo")]
            public String Logo
            {
                get;
                set;
            }

            [JsonProperty("creator")]
            public String Creator
            {
                get;
                set;
            }

            [JsonProperty("status")]
            public Nullable<Int32> Status
            {
                get;
                set;
            }

            [JsonProperty("weight")]
            public String Weight
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

            [JsonProperty("outer_id")]
            public String OuterId
            {
                get;
                set;
            }

        }

    }

}
