﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class PromoSkuVO : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("item_num")]
        public String ItemNum
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

        [JsonProperty("sku_name")]
        public String SkuName
        {
            get;
            set;
        }

        [JsonProperty("promo_id")]
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        [JsonProperty("jd_price")]
        public String JdPrice
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

        [JsonProperty("seq")]
        public Nullable<Int32> Seq
        {
            get;
            set;
        }

        [JsonProperty("num")]
        public Nullable<Int32> Num
        {
            get;
            set;
        }

        [JsonProperty("bind_type")]
        public Nullable<Int32> BindType
        {
            get;
            set;
        }

    }

}
