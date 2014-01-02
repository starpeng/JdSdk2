﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderSopPrintData : JdObject
    {
        [JsonProperty("invoice_title")]
        public String InvoiceTitle
        {
            get;
            set;
        }

        [JsonProperty("invoice_type")]
        public String InvoiceType
        {
            get;
            set;
        }

        [JsonProperty("invoice_content")]
        public String InvoiceContent
        {
            get;
            set;
        }

    }

}
