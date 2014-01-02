﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PlanInfoVO : JdObject
    {
        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        [JsonProperty("startDate")]
        public String StartDate
        {
            get;
            set;
        }

        [JsonProperty("endDate")]
        public String EndDate
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
