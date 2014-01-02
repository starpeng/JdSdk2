﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class JosGoodsInfo : JdObject
    {
        [JsonProperty("code")]
        public Nullable<Int32> Code
        {
            get;
            set;
        }

        [JsonProperty("wp_name")]
        public String WpName
        {
            get;
            set;
        }

        [JsonProperty("image_url")]
        public String ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("w_name")]
        public String WName
        {
            get;
            set;
        }

        [JsonProperty("wp_id")]
        public Nullable<Int64> WpId
        {
            get;
            set;
        }

        [JsonProperty("class_names")]
        public List<String> ClassNames
        {
            get;
            set;
        }

        [JsonProperty("class_ids")]
        public List<Int32> ClassIds
        {
            get;
            set;
        }

        [JsonProperty("image_urls")]
        public List<String> ImageUrls
        {
            get;
            set;
        }

        [JsonProperty("sku_similars")]
        public List<JosSkuInfo> SkuSimilars
        {
            get;
            set;
        }

    }

}
