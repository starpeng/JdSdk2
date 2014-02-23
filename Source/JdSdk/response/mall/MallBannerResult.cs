﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class MallBannerResult : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("banner_url")]
        public String BannerUrl
        {
            get;
            set;
        }

        [JsonProperty("banner_link")]
        public String BannerLink
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

        [JsonProperty("seller_id")]
        public Nullable<Int64> SellerId
        {
            get;
            set;
        }

        [JsonProperty("mall_id")]
        public Nullable<Int64> MallId
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

    }

}
