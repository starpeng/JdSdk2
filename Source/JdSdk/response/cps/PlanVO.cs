﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PlanVO : JdObject
    {
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

        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

        [JsonProperty("categoryCommision")]
        public List<UnionCategoryCommision> CategoryCommision
        {
            get;
            set;
        }

        [JsonProperty("planGoods")]
        public List<GoodsVO> PlanGoods
        {
            get;
            set;
        }

        [JsonProperty("planActivity")]
        public List<UnionPlanActivity> PlanActivity
        {
            get;
            set;
        }

    }

}
