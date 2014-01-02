﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderResult : JdObject
    {
        [JsonProperty("order_total")]
        public Nullable<Int32> OrderTotal
        {
            get;
            set;
        }

        [JsonProperty("order_info_list")]
        public List<OrderSearchInfo> OrderInfoList
        {
            get;
            set;
        }

    }

}
