﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class OrderDetailForJosDto : JdObject
    {
        [JsonProperty("skuId")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("commodityName")]
        public String CommodityName
        {
            get;
            set;
        }

        [JsonProperty("commodityNum")]
        public Nullable<Int32> CommodityNum
        {
            get;
            set;
        }

    }

}
