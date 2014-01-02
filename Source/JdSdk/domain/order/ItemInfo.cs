﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class ItemInfo : JdObject
    {
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("outer_sku_id")]
        public String OuterSkuId
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

        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        [JsonProperty("gift_point")]
        public String GiftPoint
        {
            get;
            set;
        }

        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        [JsonProperty("item_total")]
        public String ItemTotal
        {
            get;
            set;
        }

        [JsonProperty("product_no")]
        public String ProductNo
        {
            get;
            set;
        }

    }

}
