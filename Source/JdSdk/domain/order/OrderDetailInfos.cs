﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderDetailInfos : JdObject
    {
        [JsonProperty("waybill_id")]
        public String WaybillId
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public String VenderId
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

        [JsonProperty("order_payment")]
        public String OrderPayment
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

        [JsonProperty("consignee_info")]
        public OrderUserInfo ConsigneeInfo
        {
            get;
            set;
        }

    }

}
