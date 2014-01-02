﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PromotionShopVO : JdObject
    {
        [JsonProperty("pk")]
        public Nullable<Int64> Pk
        {
            get;
            set;
        }

        [JsonProperty("pop_id")]
        public Nullable<Int64> PopId
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

        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        [JsonProperty("shop_mainurl")]
        public String ShopMainurl
        {
            get;
            set;
        }

        [JsonProperty("main_categories")]
        public String MainCategories
        {
            get;
            set;
        }

        [JsonProperty("shop_url")]
        public String ShopUrl
        {
            get;
            set;
        }

        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        [JsonProperty("goods_volume")]
        public Nullable<Int64> GoodsVolume
        {
            get;
            set;
        }

        [JsonProperty("accumulative_total")]
        public Nullable<Int64> AccumulativeTotal
        {
            get;
            set;
        }

        [JsonProperty("praise_degree")]
        public Nullable<Decimal> PraiseDegree
        {
            get;
            set;
        }

        [JsonProperty("update_time")]
        public Nullable<DateTime> UpdateTime
        {
            get;
            set;
        }

        [JsonProperty("insert_time")]
        public Nullable<DateTime> InsertTime
        {
            get;
            set;
        }

    }

}
