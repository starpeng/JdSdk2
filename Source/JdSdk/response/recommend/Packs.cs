﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Recommend
{
﻿    [Serializable]
    public class Packs : JdObject
    {
        [JsonProperty("packListPrice")]
        public String PackListPrice
        {
            get;
            set;
        }

        [JsonProperty("packPrice")]
        public String PackPrice
        {
            get;
            set;
        }

        [JsonProperty("mainSkuPicUrl")]
        public String MainSkuPicUrl
        {
            get;
            set;
        }

        [JsonProperty("packId")]
        public String PackId
        {
            get;
            set;
        }

        [JsonProperty("mainSkuId")]
        public String MainSkuId
        {
            get;
            set;
        }

        [JsonProperty("discount")]
        public String Discount
        {
            get;
            set;
        }

        [JsonProperty("mainSkuName")]
        public String MainSkuName
        {
            get;
            set;
        }

        [JsonProperty("packs2")]
        public List<Product> Packs2
        {
            get;
            set;
        }

    }

}
