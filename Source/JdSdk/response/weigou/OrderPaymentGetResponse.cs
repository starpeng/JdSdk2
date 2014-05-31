﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Weigou.PaymentShipmentExportService;

namespace JdSdk.Response.Weigou
{
﻿    [Serializable]
    public class OrderPaymentGetResponse : JdResponse
    {
        [JsonProperty("getpaymentlist_result")]
        public GetPaymentListResult GetpaymentlistResult
        {
            get;
            set;
        }

    }

}
