﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.JosStockSalesService
{
﻿    [Serializable]
    public class JosStockSalesDetail : JdObject
    {
        [JsonProperty("product_code")]
        public String ProductCode
        {
            get;
            set;
        }

        [JsonProperty("product_name")]
        public String ProductName
        {
            get;
            set;
        }

        [JsonProperty("stock_count")]
        public Nullable<Int64> StockCount
        {
            get;
            set;
        }

        [JsonProperty("sales")]
        public Nullable<Int64> Sales
        {
            get;
            set;
        }

    }

}
