﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class ResultStatus : JdObject
    {
        [JsonProperty("code")]
        public Nullable<Int32> Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("planId")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

    }

}
