﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.ReturnOrderJosAPI
{
﻿    [Serializable]
    public class RoDetailDto : JdObject
    {
        [JsonProperty("wareId")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("brandName")]
        public String BrandName
        {
            get;
            set;
        }

        [JsonProperty("returnsPrice")]
        public Nullable<Decimal> ReturnsPrice
        {
            get;
            set;
        }

        [JsonProperty("returnsNum")]
        public Nullable<Int32> ReturnsNum
        {
            get;
            set;
        }

        [JsonProperty("factNum")]
        public Nullable<Int32> FactNum
        {
            get;
            set;
        }

        [JsonProperty("totalPrice")]
        public Nullable<Decimal> TotalPrice
        {
            get;
            set;
        }

        [JsonProperty("isbn")]
        public String Isbn
        {
            get;
            set;
        }

        [JsonProperty("discount")]
        public Nullable<Decimal> Discount
        {
            get;
            set;
        }

        [JsonProperty("makePrice")]
        public Nullable<Decimal> MakePrice
        {
            get;
            set;
        }

    }

}
