﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Weigou.PaymentShipmentExportService
{
﻿    [Serializable]
    public class CombinationPaymentVO : JdObject
    {
        [JsonProperty("mainPaymentVO")]
        public PaymentVO MainPaymentVO
        {
            get;
            set;
        }

        [JsonProperty("subPaymentVO")]
        public PaymentVO SubPaymentVO
        {
            get;
            set;
        }

    }

}
