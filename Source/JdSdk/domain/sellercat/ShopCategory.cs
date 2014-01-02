﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Sellercat
{
﻿    [Serializable]
    public class ShopCategory : JdObject
    {
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        [JsonProperty("parent_id")]
        public Nullable<Int64> ParentId
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

        [JsonProperty("isparent")]
        public Nullable<Boolean> IsParent
        {
            get;
            set;
        }

        [JsonProperty("isopen")]
        public Nullable<Boolean> IsOpen
        {
            get;
            set;
        }

        [JsonProperty("ishomeshow")]
        public Nullable<Boolean> IsHomeShow
        {
            get;
            set;
        }

        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        [JsonProperty("index_id")]
        public Nullable<Int32> OrderNo
        {
            get;
            set;
        }

    }

}
