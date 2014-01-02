﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class StockDetail : JdObject
    {
        [JsonProperty("goods_no")]
        public String GoodsNo
        {
            get;
            set;
        }

        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        [JsonProperty("stock_qty")]
        public Nullable<Int32> StockQty
        {
            get;
            set;
        }

        [JsonProperty("available_qty")]
        public Nullable<Int32> AvailableQty
        {
            get;
            set;
        }

        [JsonProperty("preemption_qty")]
        public Nullable<Int32> PreemptionQty
        {
            get;
            set;
        }

        [JsonProperty("goods_status")]
        public String GoodsStatus
        {
            get;
            set;
        }

    }

}
