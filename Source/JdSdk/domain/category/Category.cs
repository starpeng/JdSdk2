﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Category
{
﻿    [Serializable]
    public class Category : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int32> Id
        {
            get;
            set;
        }

        [JsonProperty("fid")]
        public Nullable<Int32> Fid
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

        [JsonProperty("index_id")]
        public Nullable<Int32> IndexId
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

        [JsonProperty("lev")]
        public Nullable<Int32> Lev
        {
            get;
            set;
        }

        [JsonProperty("isparent")]
        public Nullable<Boolean> IsParent
        {
            get;
            set;
        }

    }

}
