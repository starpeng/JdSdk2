﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Recommend
{
﻿    [Serializable]
    public class Product : JdObject
    {
        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("skuPicUrl")]
        public String SkuPicUrl
        {
            get;
            set;
        }

        [JsonProperty("skuName")]
        public String SkuName
        {
            get;
            set;
        }

    }

}
