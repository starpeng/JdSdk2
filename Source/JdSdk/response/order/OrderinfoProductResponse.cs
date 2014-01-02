﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderinfoProductResponse : JdObject
    {
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

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
        public Nullable<Double> JdPrice
        {
            get;
            set;
        }

        [JsonProperty("gift_point")]
        public Nullable<Int32> GiftPoint
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
        public Nullable<Int32> ItemTotal
        {
            get;
            set;
        }

    }

}
