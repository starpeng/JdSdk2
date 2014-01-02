﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Category
{
﻿    [Serializable]
    public class Group : JdObject
    {
        [JsonProperty("cid")]
        public Nullable<Int32> CategoryId
        {
            get;
            set;
        }

        [JsonProperty("group_id")]
        public Nullable<Int32> Id
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

        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        [JsonProperty("index_id")]
        public Nullable<Int32> Index
        {
            get;
            set;
        }

    }

}
