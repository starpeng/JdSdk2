﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class BillDetailVO : JdObject
    {
        [JsonProperty("bill_no")]
        public Nullable<Int64> BillNo
        {
            get;
            set;
        }

        [JsonProperty("plan_id")]
        public String PlanId
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

        [JsonProperty("mode")]
        public String Mode
        {
            get;
            set;
        }

        [JsonProperty("space_site")]
        public String SpaceSite
        {
            get;
            set;
        }

        [JsonProperty("cost")]
        public String Cost
        {
            get;
            set;
        }

    }

}
