﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.RefundapplySaf
{
﻿    [Serializable]
    public class QueryMap : JdObject
    {
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        [JsonProperty("buyer_id")]
        public String BuyerId
        {
            get;
            set;
        }

        [JsonProperty("buyer_name")]
        public String BuyerName
        {
            get;
            set;
        }

        [JsonProperty("check_time")]
        public String CheckTime
        {
            get;
            set;
        }

        [JsonProperty("apply_time")]
        public String ApplyTime
        {
            get;
            set;
        }

        [JsonProperty("apply_refund_sum")]
        public String ApplyRefundSum
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        [JsonProperty("check_username")]
        public String CheckUsername
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

    }

}
