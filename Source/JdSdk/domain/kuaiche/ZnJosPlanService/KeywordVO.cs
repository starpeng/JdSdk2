﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Kuaiche.ZnJosPlanService
{
﻿    [Serializable]
    public class KeywordVO : JdObject
    {
        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        [JsonProperty("wgroup_id")]
        public Nullable<Int64> WgroupId
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public Nullable<Decimal> Price
        {
            get;
            set;
        }

    }

}
