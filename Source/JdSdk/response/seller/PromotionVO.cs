﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class PromotionVO : JdObject
    {
        [JsonProperty("promo_id")]
        public Nullable<Int64> PromoId
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

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("bound")]
        public Nullable<Int32> Bound
        {
            get;
            set;
        }

        [JsonProperty("begin_time")]
        public String BeginTime
        {
            get;
            set;
        }

        [JsonProperty("end_time")]
        public String EndTime
        {
            get;
            set;
        }

        [JsonProperty("member")]
        public Nullable<Int32> Member
        {
            get;
            set;
        }

        [JsonProperty("slogan")]
        public String Slogan
        {
            get;
            set;
        }

        [JsonProperty("comment")]
        public String Comment
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

    }

}
