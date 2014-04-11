﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Supplier.JosStockSalesService;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class VcStockSalesDetailGetResponse : JdResponse
    {
        [JsonProperty("arg43")]
        public List<JosStockSalesDetail> Arg43
        {
            get;
            set;
        }

    }

}
