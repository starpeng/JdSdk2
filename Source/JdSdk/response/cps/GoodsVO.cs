﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class GoodsVO : JdObject
    {
        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("goodsName")]
        public String GoodsName
        {
            get;
            set;
        }

        [JsonProperty("saleVolume")]
        public Nullable<Int32> SaleVolume
        {
            get;
            set;
        }

        [JsonProperty("praiseDegree")]
        public Nullable<Decimal> PraiseDegree
        {
            get;
            set;
        }

        [JsonProperty("commisionRatio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

    }

}
