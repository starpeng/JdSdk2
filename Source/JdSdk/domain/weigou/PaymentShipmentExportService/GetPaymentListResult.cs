﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Weigou.PaymentShipmentExportService
{
﻿    [Serializable]
    public class GetPaymentListResult : JdObject
    {
        [JsonProperty("paymentTypeVOList")]
        public List<CombinationPaymentVO> PaymentTypeVOList
        {
            get;
            set;
        }

        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("resultFlag")]
        public Nullable<Boolean> ResultFlag
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }

}
