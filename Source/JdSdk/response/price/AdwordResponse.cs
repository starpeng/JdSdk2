﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class AdwordResponse : JdObject
    {
        [JsonProperty("skuId")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("promotionInfoList")]
        public List<PromotionInfo> PromotionInfoList
        {
            get;
            set;
        }

    }

}
