﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class AdwordCoupon : JdObject
    {
        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("key")]
        public String Key
        {
            get;
            set;
        }

        [JsonProperty("couponQouta")]
        public Nullable<Int32> CouponQouta
        {
            get;
            set;
        }

    }

}
