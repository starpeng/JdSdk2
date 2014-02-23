﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    [Serializable]
    public class CategoryResult : JdObject
    {
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        [JsonProperty("parent_cid")]
        public Nullable<Int64> ParentCid
        {
            get;
            set;
        }

        [JsonProperty("seller_id")]
        public Nullable<Int64> SellerId
        {
            get;
            set;
        }

        [JsonProperty("c_name")]
        public String CName
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        [JsonProperty("has_leaf")]
        public Nullable<Int32> HasLeaf
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

        [JsonProperty("sort_number")]
        public Nullable<Int32> SortNumber
        {
            get;
            set;
        }

        [JsonProperty("home_show")]
        public Nullable<Int32> HomeShow
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }

}
