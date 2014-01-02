﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionPlan : JdObject
    {
        [JsonProperty("pk")]
        public Nullable<Int64> Pk
        {
            get;
            set;
        }

        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        [JsonProperty("startDate")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        [JsonProperty("endDate")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        [JsonProperty("averageCommision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        [JsonProperty("goodsCount")]
        public Nullable<Int32> GoodsCount
        {
            get;
            set;
        }

        [JsonProperty("activityCount")]
        public Nullable<Int32> ActivityCount
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

    }

}
