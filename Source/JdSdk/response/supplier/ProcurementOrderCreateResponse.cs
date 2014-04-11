﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class ProcurementOrderCreateResponse : JdResponse
    {
        [JsonProperty("purchaseOrderCodes")]
        public List<Int64> PurchaseOrderCodes
        {
            get;
            set;
        }

    }

}
