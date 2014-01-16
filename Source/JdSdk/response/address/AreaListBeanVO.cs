﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Address
{
﻿    [Serializable]
    public class AreaListBeanVO : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("is3cod")]
        public String Is3cod
        {
            get;
            set;
        }

        [JsonProperty("cod")]
        public Nullable<Boolean> Cod
        {
            get;
            set;
        }

    }

}
