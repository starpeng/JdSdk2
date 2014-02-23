﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ItemPictureProxyResult : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("item_id")]
        public Nullable<Int64> ItemId
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

        [JsonProperty("picture_url")]
        public String PictureUrl
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
