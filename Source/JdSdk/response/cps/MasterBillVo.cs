﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class MasterBillVo : JdObject
    {
        [JsonProperty("bill_id")]
        public Nullable<Int64> BillId
        {
            get;
            set;
        }

        [JsonProperty("union_id")]
        public Nullable<Int64> UnionId
        {
            get;
            set;
        }

        [JsonProperty("pay_month")]
        public String PayMonth
        {
            get;
            set;
        }

        [JsonProperty("pay_time")]
        public Nullable<DateTime> PayTime
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Double> Total
        {
            get;
            set;
        }

        [JsonProperty("tax")]
        public Nullable<Double> Tax
        {
            get;
            set;
        }

        [JsonProperty("pay_amount")]
        public Nullable<Double> PayAmount
        {
            get;
            set;
        }

        [JsonProperty("after_tax")]
        public Nullable<Double> AfterTax
        {
            get;
            set;
        }

        [JsonProperty("adjust")]
        public Nullable<Double> Adjust
        {
            get;
            set;
        }

        [JsonProperty("bank_name")]
        public String BankName
        {
            get;
            set;
        }

        [JsonProperty("bank_card")]
        public String BankCard
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

        [JsonProperty("pay_id")]
        public String PayId
        {
            get;
            set;
        }

        [JsonProperty("technical_fee")]
        public Nullable<Double> TechnicalFee
        {
            get;
            set;
        }

    }

}
