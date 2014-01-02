﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PlanListVO : JdObject
    {
        [JsonProperty("totalCount")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("planList")]
        public List<UnionPlan> PlanList
        {
            get;
            set;
        }

        [JsonProperty("totalPage")]
        public Nullable<Int32> TotalPage
        {
            get;
            set;
        }

    }

}
