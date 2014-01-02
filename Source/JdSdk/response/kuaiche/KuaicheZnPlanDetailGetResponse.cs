﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnPlanDetailGetResponse : JdResponse
    {
        [JsonProperty("plan_detail_info")]
        public PlanDetailInfo PlanDetailInfo
        {
            get;
            set;
        }

    }

}
