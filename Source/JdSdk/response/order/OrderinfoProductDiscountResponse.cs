﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderinfoProductDiscountResponse : JdObject
    {
        [JsonProperty("coupon_price")]
        public Nullable<Double> CouponPrice
        {
            get;
            set;
        }

        [JsonProperty("coupon_type")]
        public Nullable<Byte> CouponType
        {
            get;
            set;
        }

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

    }

}
