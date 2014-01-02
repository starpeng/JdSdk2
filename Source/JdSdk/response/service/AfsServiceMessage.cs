﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceMessage : JdObject
    {
        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
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

        [JsonProperty("afsCategoryId")]
        public Nullable<Int32> AfsCategoryId
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

        [JsonProperty("wareName")]
        public String WareName
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

    }

}
