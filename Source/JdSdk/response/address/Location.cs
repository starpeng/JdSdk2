﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Address
{
﻿    [Serializable]
    public class Location : JdObject
    {
        [JsonProperty("country")]
        public String Country
        {
            get;
            set;
        }

        [JsonProperty("province")]
        public String Province
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public String City
        {
            get;
            set;
        }

        [JsonProperty("district")]
        public String District
        {
            get;
            set;
        }

        [JsonProperty("subdistrict")]
        public String Subdistrict
        {
            get;
            set;
        }

        [JsonProperty("community")]
        public String Community
        {
            get;
            set;
        }

        [JsonProperty("road")]
        public String Road
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

    }

}
