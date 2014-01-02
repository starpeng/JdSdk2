﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsRefundDto : JdObject
    {
        [JsonProperty("customer_order_id")]
        public String CustomerOrderId
        {
            get;
            set;
        }

        [JsonProperty("typeId")]
        public Nullable<Int32> TypeId
        {
            get;
            set;
        }

        [JsonProperty("itemName")]
        public String ItemName
        {
            get;
            set;
        }

        [JsonProperty("itemMoney")]
        public Nullable<Decimal> ItemMoney
        {
            get;
            set;
        }

    }

}
