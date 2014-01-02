﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderLbpWaybillUpdateResponse : JdResponse
    {
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("order_id")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

    }

}
