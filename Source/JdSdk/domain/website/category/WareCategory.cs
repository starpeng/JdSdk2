﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Category
{
﻿    [Serializable]
    public class WareCategory : JdObject
    {
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        [JsonProperty("fid")]
        public Nullable<Int64> Fid
        {
            get;
            set;
        }

        [JsonProperty("level")]
        public Nullable<Int64> Level
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

        [JsonProperty("index")]
        public Nullable<Int64> Index
        {
            get;
            set;
        }

        [JsonProperty("child_level")]
        public Nullable<Int64> ChildLevel
        {
            get;
            set;
        }

    }

}
