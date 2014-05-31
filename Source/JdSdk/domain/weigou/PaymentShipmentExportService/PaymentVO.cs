﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Weigou.PaymentShipmentExportService
{
﻿    [Serializable]
    public class PaymentVO : JdObject
    {
        [JsonProperty("paymentId")]
        public Nullable<Int32> PaymentId
        {
            get;
            set;
        }

    }

}
