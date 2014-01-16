﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class WaiterDailyStat : JdObject
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

        [JsonProperty("result")]
        public String Result
        {
            get;
            set;
        }

    }

}
