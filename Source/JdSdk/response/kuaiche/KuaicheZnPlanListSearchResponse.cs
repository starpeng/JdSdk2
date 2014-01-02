﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnPlanListSearchResponse : JdResponse
    {
        [JsonProperty("plan_list_info")]
        public QueryPlanReturnInfo PlanListInfo
        {
            get;
            set;
        }

    }

}
