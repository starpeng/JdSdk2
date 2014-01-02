﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Promotion
{
﻿    [Serializable]
    public class PromotionProduct : JdObject
    {
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("prod_name")]
        public String ProdName
        {
            get;
            set;
        }

        [JsonProperty("prod_id")]
        public Nullable<Int64> ProdId
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        [JsonProperty("promo_price")]
        public String PromoPrice
        {
            get;
            set;
        }

        [JsonProperty("ismain")]
        public String IsMain
        {
            get;
            set;
        }

    }

}
