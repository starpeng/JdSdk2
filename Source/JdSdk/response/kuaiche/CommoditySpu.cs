﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class CommoditySpu : JdObject
    {
        [JsonProperty("material_id")]
        public Nullable<Int64> MaterialId
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
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

        [JsonProperty("domain")]
        public String Domain
        {
            get;
            set;
        }

    }

}
