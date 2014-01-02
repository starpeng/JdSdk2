﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class Catelogy : JdObject
    {
        [JsonProperty("fid")]
        public Nullable<Int32> Fid
        {
            get;
            set;
        }

        [JsonProperty("icon")]
        public String Icon
        {
            get;
            set;
        }

        [JsonProperty("orderSort")]
        public Nullable<Int32> OrderSort
        {
            get;
            set;
        }

        [JsonProperty("level")]
        public Nullable<Int32> Level
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public String Description
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

        [JsonProperty("cid")]
        public Nullable<Int32> Cid
        {
            get;
            set;
        }

    }

}
