﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class Evaluation : JdObject
    {
        [JsonProperty("customer")]
        public String Customer
        {
            get;
            set;
        }

        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        [JsonProperty("score")]
        public Nullable<Int32> Score
        {
            get;
            set;
        }

        [JsonProperty("evaTime")]
        public Nullable<DateTime> EvaTime
        {
            get;
            set;
        }

    }

}
