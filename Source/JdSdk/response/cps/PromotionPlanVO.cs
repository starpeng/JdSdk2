﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PromotionPlanVO : JdObject
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

        [JsonProperty("plan_name")]
        public String PlanName
        {
            get;
            set;
        }

        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        [JsonProperty("end_date")]
        public Nullable<DateTime> EndDate
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

        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        [JsonProperty("goods_count")]
        public Nullable<Int32> GoodsCount
        {
            get;
            set;
        }

        [JsonProperty("activity_count")]
        public Nullable<Int32> ActivityCount
        {
            get;
            set;
        }

    }

}
