﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Order
{
﻿    [Serializable]
    public class OrderCreateResult : JdObject
    {
        [JsonProperty("order_id")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("flag")]
        public Nullable<Boolean> Flag
        {
            get;
            set;
        }

    }

}
