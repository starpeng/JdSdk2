﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.PurchaseOrderJosAPI
{
﻿    [Serializable]
    public class DetailResultDto : JdObject
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

        [JsonProperty("orderId")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        [JsonProperty("deliveryTime")]
        public Nullable<DateTime> DeliveryTime
        {
            get;
            set;
        }

        [JsonProperty("allocationDetailList")]
        public List<PurchaseAllocationDetailDto> AllocationDetailList
        {
            get;
            set;
        }

    }

}
