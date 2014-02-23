﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class MallRecommendResult : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
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

        [JsonProperty("position")]
        public Nullable<Int32> Position
        {
            get;
            set;
        }

        [JsonProperty("rec_type")]
        public Nullable<Int32> RecType
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

        [JsonProperty("mall_id")]
        public Nullable<Int64> MallId
        {
            get;
            set;
        }

        [JsonProperty("recommend_ware_list")]
        public List<MallRecommendWareResult> RecommendWareList
        {
            get;
            set;
        }

    }

}
