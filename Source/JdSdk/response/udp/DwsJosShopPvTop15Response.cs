﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DwsJosShopPvTop15Response : JdObject
    {
        [JsonProperty("spuid")]
        public Nullable<Int64> Spuid
        {
            get;
            set;
        }

        [JsonProperty("proid")]
        public Nullable<Int64> Proid
        {
            get;
            set;
        }

        [JsonProperty("proname")]
        public String Proname
        {
            get;
            set;
        }

        [JsonProperty("rn")]
        public Nullable<Int32> Rn
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

    }

}
