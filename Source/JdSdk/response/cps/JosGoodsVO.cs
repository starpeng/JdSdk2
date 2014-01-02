﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class JosGoodsVO : JdObject
    {
        [JsonProperty("pk")]
        public Nullable<Int64> Pk
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
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

        [JsonProperty("goods_name")]
        public String GoodsName
        {
            get;
            set;
        }

        [JsonProperty("unitPrice")]
        public Nullable<Decimal> UnitPrice
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

        [JsonProperty("mainimgurl")]
        public String Mainimgurl
        {
            get;
            set;
        }

        [JsonProperty("commision_ratio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

        [JsonProperty("commision")]
        public Nullable<Decimal> Commision
        {
            get;
            set;
        }

        [JsonProperty("ware_url")]
        public String WareUrl
        {
            get;
            set;
        }

        [JsonProperty("recent_sales")]
        public String RecentSales
        {
            get;
            set;
        }

        [JsonProperty("total_sales")]
        public Nullable<Int32> TotalSales
        {
            get;
            set;
        }

        [JsonProperty("start_time")]
        public Nullable<DateTime> StartTime
        {
            get;
            set;
        }

        [JsonProperty("plan_endtime")]
        public Nullable<DateTime> PlanEndtime
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

        [JsonProperty("update_time")]
        public Nullable<DateTime> UpdateTime
        {
            get;
            set;
        }

    }

}
