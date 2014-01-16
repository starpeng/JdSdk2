﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceProcessFacade
{
﻿    [Serializable]
    public class AfsServiceHistory : JdObject
    {
        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
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

        [JsonProperty("customerName")]
        public String CustomerName
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

    }

}
