﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.JosStockSalesService
{
﻿    [Serializable]
    public class JosStockSales : JdObject
    {
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

        [JsonProperty("stock_turnover_days")]
        public Nullable<Decimal> StockTurnoverDays
        {
            get;
            set;
        }

        [JsonProperty("stock_rate")]
        public Nullable<Decimal> StockRate
        {
            get;
            set;
        }

        [JsonProperty("manual_vlt")]
        public Nullable<Decimal> ManualVlt
        {
            get;
            set;
        }

        [JsonProperty("auto_vlt")]
        public Nullable<Decimal> AutoVlt
        {
            get;
            set;
        }

        [JsonProperty("week")]
        public String Week
        {
            get;
            set;
        }

        [JsonProperty("manual_sku_order_fill_rate")]
        public Nullable<Decimal> ManualSkuOrderFillRate
        {
            get;
            set;
        }

        [JsonProperty("manual_units_order_fill_rate")]
        public Nullable<Decimal> ManualUnitsOrderFillRate
        {
            get;
            set;
        }

        [JsonProperty("auto_sku_order_fill_rate")]
        public Nullable<Decimal> AutoSkuOrderFillRate
        {
            get;
            set;
        }

        [JsonProperty("auto_units_order_fill_rate")]
        public Nullable<Decimal> AutoUnitsOrderFillRate
        {
            get;
            set;
        }

        [JsonProperty("sku_order_fill_rate")]
        public Nullable<Decimal> SkuOrderFillRate
        {
            get;
            set;
        }

        [JsonProperty("units_order_fill_rate")]
        public Nullable<Decimal> UnitsOrderFillRate
        {
            get;
            set;
        }

    }

}
