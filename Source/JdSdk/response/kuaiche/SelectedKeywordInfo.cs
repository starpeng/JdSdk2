﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class SelectedKeywordInfo : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
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

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("wgroup_id")]
        public String WgroupId
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
