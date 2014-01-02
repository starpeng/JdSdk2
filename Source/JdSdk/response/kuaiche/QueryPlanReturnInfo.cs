﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class QueryPlanReturnInfo : JdObject
    {
        [JsonProperty("total_number")]
        public Nullable<Int32> TotalNumber
        {
            get;
            set;
        }

        [JsonProperty("plan_list")]
        public List<PlanMainInfo> PlanList
        {
            get;
            set;
        }

    }

}
