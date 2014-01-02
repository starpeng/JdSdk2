﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceOut : JdObject
    {
        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("afsCategoryId")]
        public Nullable<Int32> AfsCategoryId
        {
            get;
            set;
        }

        [JsonProperty("afsApplyId")]
        public Nullable<Int32> AfsApplyId
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

        [JsonProperty("orderRemark")]
        public String OrderRemark
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

        [JsonProperty("pickwareProvince")]
        public Nullable<Int32> PickwareProvince
        {
            get;
            set;
        }

        [JsonProperty("pickwareCity")]
        public Nullable<Int32> PickwareCity
        {
            get;
            set;
        }

        [JsonProperty("pickwareCounty")]
        public Nullable<Int32> PickwareCounty
        {
            get;
            set;
        }

        [JsonProperty("pickwareVillage")]
        public Nullable<Int32> PickwareVillage
        {
            get;
            set;
        }

        [JsonProperty("pickwareAddress")]
        public String PickwareAddress
        {
            get;
            set;
        }

        [JsonProperty("returnwareProvince")]
        public Nullable<Int32> ReturnwareProvince
        {
            get;
            set;
        }

        [JsonProperty("returnwareCity")]
        public Nullable<Int32> ReturnwareCity
        {
            get;
            set;
        }

        [JsonProperty("returnwareCounty")]
        public Nullable<Int32> ReturnwareCounty
        {
            get;
            set;
        }

        [JsonProperty("returnwareVillage")]
        public Nullable<Int32> ReturnwareVillage
        {
            get;
            set;
        }

        [JsonProperty("returnwareAddress")]
        public String ReturnwareAddress
        {
            get;
            set;
        }

        [JsonProperty("customerExpect")]
        public Nullable<Int32> CustomerExpect
        {
            get;
            set;
        }

        [JsonProperty("questionDesc")]
        public String QuestionDesc
        {
            get;
            set;
        }

        [JsonProperty("customerName")]
        public String CustomerName
        {
            get;
            set;
        }

        [JsonProperty("customerMobilePhone")]
        public String CustomerMobilePhone
        {
            get;
            set;
        }

        [JsonProperty("customerEmail")]
        public String CustomerEmail
        {
            get;
            set;
        }

        [JsonProperty("approveName")]
        public String ApproveName
        {
            get;
            set;
        }

        [JsonProperty("afsApplyTime")]
        public Nullable<DateTime> AfsApplyTime
        {
            get;
            set;
        }

        [JsonProperty("approvedDate")]
        public Nullable<DateTime> ApprovedDate
        {
            get;
            set;
        }

        [JsonProperty("processedDate")]
        public Nullable<DateTime> ProcessedDate
        {
            get;
            set;
        }

        [JsonProperty("receiveDate")]
        public Nullable<DateTime> ReceiveDate
        {
            get;
            set;
        }

        [JsonProperty("createName")]
        public String CreateName
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

    }

}
