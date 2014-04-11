﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Supplier.JosStockSalesService;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class VcStockSalesGetResponse : JdResponse
    {
        [JsonProperty("arg36")]
        public List<JosStockSales> Arg36
        {
            get;
            set;
        }

    }

}
