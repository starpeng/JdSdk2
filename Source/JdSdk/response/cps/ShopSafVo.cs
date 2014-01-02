﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class ShopSafVo : JdObject
    {
        [JsonProperty("shop_pk")]
        public Nullable<Int64> ShopPk
        {
            get;
            set;
        }

        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        [JsonProperty("shop_promotionUrl")]
        public String ShopPromotionUrl
        {
            get;
            set;
        }

        [JsonProperty("shop_commRatio")]
        public Nullable<Decimal> ShopCommRatio
        {
            get;
            set;
        }

        [JsonProperty("shop_praiseDegree")]
        public Nullable<Decimal> ShopPraiseDegree
        {
            get;
            set;
        }

        [JsonProperty("shop_promQuantity")]
        public Nullable<Int64> ShopPromQuantity
        {
            get;
            set;
        }

        [JsonProperty("shop_goodsVolume")]
        public Nullable<Int64> ShopGoodsVolume
        {
            get;
            set;
        }

        [JsonProperty("shop_materialUrl")]
        public String ShopMaterialUrl
        {
            get;
            set;
        }

        [JsonProperty("shop_mainCategories")]
        public String ShopMainCategories
        {
            get;
            set;
        }

    }

}
