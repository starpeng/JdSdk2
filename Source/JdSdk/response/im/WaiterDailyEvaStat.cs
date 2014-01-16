﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class WaiterDailyEvaStat : JdObject
    {
        [JsonProperty("date")]
        public String Date
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

        [JsonProperty("score")]
        public Nullable<Int32> Score
        {
            get;
            set;
        }

        [JsonProperty("count")]
        public Nullable<Int32> Count
        {
            get;
            set;
        }

    }

}
