﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class Image : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int32> Id
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("path")]
        public String Path
        {
            get;
            set;
        }

        [JsonProperty("yn")]
        public Nullable<Int32> Yn
        {
            get;
            set;
        }

        [JsonProperty("is_primary")]
        public Nullable<Int32> IsPrimary
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

        [JsonProperty("position")]
        public Nullable<Int32> Position
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

    }

}
