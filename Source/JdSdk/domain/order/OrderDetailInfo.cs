﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderDetailInfo : JdObject
    {
        [JsonProperty("orderInfo")]
        public OrderInfo OrderInfo
        {
            get;
            set;
        }

    }

}
