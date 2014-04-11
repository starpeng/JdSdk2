﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.PurchaseOrderJosAPI
{
﻿    [Serializable]
    public class OrderResultDto : JdObject
    {
        [JsonProperty("pageIndex")]
        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        [JsonProperty("pageSize")]
        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        [JsonProperty("recordCount")]
        public Nullable<Int32> RecordCount
        {
            get;
            set;
        }

        [JsonProperty("totalPage")]
        public Nullable<Int32> TotalPage
        {
            get;
            set;
        }

        [JsonProperty("purchaseOrderList")]
        public List<PurchaseOrderDto> PurchaseOrderList
        {
            get;
            set;
        }

    }

}
