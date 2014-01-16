﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class AfsFinanceDetailOut : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int32> Id
        {
            get;
            set;
        }

        [JsonProperty("orderId")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        [JsonProperty("wareId")]
        public Nullable<Int32> WareId
        {
            get;
            set;
        }

        [JsonProperty("financeId")]
        public Nullable<Int32> FinanceId
        {
            get;
            set;
        }

        [JsonProperty("refundMoney")]
        public Nullable<Decimal> RefundMoney
        {
            get;
            set;
        }

        [JsonProperty("payMoney")]
        public Nullable<Decimal> PayMoney
        {
            get;
            set;
        }

        [JsonProperty("refundNum")]
        public String RefundNum
        {
            get;
            set;
        }

        [JsonProperty("account")]
        public String Account
        {
            get;
            set;
        }

        [JsonProperty("bank")]
        public String Bank
        {
            get;
            set;
        }

        [JsonProperty("createdDate")]
        public Nullable<DateTime> CreatedDate
        {
            get;
            set;
        }

    }

}
