﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class CouponDetail : JdObject
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

        [JsonProperty("coupon_type")]
        public String CouponType
        {
            get;
            set;
        }

        [JsonProperty("coupon_price")]
        public String CouponPrice
        {
            get;
            set;
        }

    }

}
