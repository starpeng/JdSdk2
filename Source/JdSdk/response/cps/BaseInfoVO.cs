﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class BaseInfoVO : JdObject
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

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

    }

}
