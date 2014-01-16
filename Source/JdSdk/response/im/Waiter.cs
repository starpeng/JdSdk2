﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class Waiter : JdObject
    {
        [JsonProperty("waiter2")]
        public String Waiter2
        {
            get;
            set;
        }

        [JsonProperty("yn")]
        public Nullable<Byte> Yn
        {
            get;
            set;
        }

        [JsonProperty("leader")]
        public Nullable<Boolean> Leader
        {
            get;
            set;
        }

        [JsonProperty("level")]
        public String Level
        {
            get;
            set;
        }

    }

}
