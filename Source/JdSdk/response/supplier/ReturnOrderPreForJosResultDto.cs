﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class ReturnOrderPreForJosResultDto : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("customOrderId")]
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        [JsonProperty("roApplyFee")]
        public Nullable<Decimal> RoApplyFee
        {
            get;
            set;
        }

        [JsonProperty("roApplyDate")]
        public Nullable<DateTime> RoApplyDate
        {
            get;
            set;
        }

        [JsonProperty("orderCreateDate")]
        public Nullable<DateTime> OrderCreateDate
        {
            get;
            set;
        }

        [JsonProperty("approvalState")]
        public Nullable<Int32> ApprovalState
        {
            get;
            set;
        }

        [JsonProperty("orderState")]
        public Nullable<Int32> OrderState
        {
            get;
            set;
        }

        [JsonProperty("roPreNo")]
        public Nullable<Int64> RoPreNo
        {
            get;
            set;
        }

        [JsonProperty("roAccount")]
        public String RoAccount
        {
            get;
            set;
        }

        [JsonProperty("roReason")]
        public String RoReason
        {
            get;
            set;
        }

        [JsonProperty("approvalSuggestion")]
        public String ApprovalSuggestion
        {
            get;
            set;
        }

        [JsonProperty("orderDetailList")]
        public List<ReturnOrderDetailForJosDto> OrderDetailList
        {
            get;
            set;
        }

    }

}
