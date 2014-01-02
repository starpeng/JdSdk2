﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class FwPvResponse : JdObject
    {
        [JsonProperty("stat_dt")]
        public String StatDt
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public String Url
        {
            get;
            set;
        }

        [JsonProperty("pv")]
        public Nullable<Int32> Pv
        {
            get;
            set;
        }

        [JsonProperty("uv")]
        public Nullable<Int32> Uv
        {
            get;
            set;
        }

    }

}
