﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceManagerFacade
{
﻿    [Serializable]
    public class AfsApplyWaitAudit : JdObject
    {
        [JsonProperty("afsApplyId")]
        public Nullable<Int32> AfsApplyId
        {
            get;
            set;
        }

        [JsonProperty("customerPin")]
        public String CustomerPin
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

        [JsonProperty("pickwareAddress")]
        public String PickwareAddress
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

        [JsonProperty("afsApplyTime")]
        public Nullable<DateTime> AfsApplyTime
        {
            get;
            set;
        }

    }

}
