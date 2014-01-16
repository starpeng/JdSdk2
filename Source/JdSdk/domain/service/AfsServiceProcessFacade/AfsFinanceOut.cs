﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class AfsFinanceOut : JdObject
    {
        [JsonProperty("userName")]
        public String UserName
        {
            get;
            set;
        }

        [JsonProperty("userId")]
        public String UserId
        {
            get;
            set;
        }

        [JsonProperty("serviceId")]
        public Nullable<Int32> ServiceId
        {
            get;
            set;
        }

        [JsonProperty("idFinance")]
        public Nullable<Int32> IdFinance
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

        [JsonProperty("reason")]
        public String Reason
        {
            get;
            set;
        }

        [JsonProperty("bilv")]
        public Nullable<Decimal> Bilv
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public Nullable<Decimal> Price
        {
            get;
            set;
        }

        [JsonProperty("margReason")]
        public String MargReason
        {
            get;
            set;
        }

        [JsonProperty("refundment")]
        public Nullable<Decimal> Refundment
        {
            get;
            set;
        }

        [JsonProperty("carriage")]
        public Nullable<Decimal> Carriage
        {
            get;
            set;
        }

        [JsonProperty("rebate")]
        public Nullable<Decimal> Rebate
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public String Type
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

        [JsonProperty("wareId")]
        public Nullable<Int32> WareId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("memberPhone")]
        public String MemberPhone
        {
            get;
            set;
        }

        [JsonProperty("opPin")]
        public String OpPin
        {
            get;
            set;
        }

        [JsonProperty("opName")]
        public String OpName
        {
            get;
            set;
        }

        [JsonProperty("opTime")]
        public String OpTime
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

        [JsonProperty("codeAccount")]
        public String CodeAccount
        {
            get;
            set;
        }

        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

    }

}
