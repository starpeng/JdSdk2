﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class AdZoneVo : JdObject
    {
        [JsonProperty("zone_id")]
        public Nullable<Int64> ZoneId
        {
            get;
            set;
        }

        [JsonProperty("union_id")]
        public Nullable<Int64> UnionId
        {
            get;
            set;
        }

        [JsonProperty("web_id")]
        public Nullable<Int64> WebId
        {
            get;
            set;
        }

        [JsonProperty("web_name")]
        public String WebName
        {
            get;
            set;
        }

        [JsonProperty("web_url")]
        public String WebUrl
        {
            get;
            set;
        }

        [JsonProperty("promotion_type")]
        public Nullable<Int64> PromotionType
        {
            get;
            set;
        }

        [JsonProperty("zone_name")]
        public String ZoneName
        {
            get;
            set;
        }

        [JsonProperty("width")]
        public Nullable<Int64> Width
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public Nullable<Int64> Height
        {
            get;
            set;
        }

        [JsonProperty("category")]
        public List<String> Category
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

        [JsonProperty("size_id")]
        public Nullable<Int64> SizeId
        {
            get;
            set;
        }

        [JsonProperty("size_name")]
        public String SizeName
        {
            get;
            set;
        }

    }

}
