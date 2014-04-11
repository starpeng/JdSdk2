﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.PurchaseOrderJosAPI
{
﻿    [Serializable]
    public class PurchaseAllocationDetailDto : JdObject
    {
        [JsonProperty("wareId")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("deliverCenterId")]
        public Nullable<Int32> DeliverCenterId
        {
            get;
            set;
        }

        [JsonProperty("deliverCenterName")]
        public String DeliverCenterName
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

        [JsonProperty("purchasePrice")]
        public Nullable<Decimal> PurchasePrice
        {
            get;
            set;
        }

        [JsonProperty("totoalPrice")]
        public Nullable<Decimal> TotoalPrice
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

        [JsonProperty("currentMakePrice")]
        public Nullable<Decimal> CurrentMakePrice
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

        [JsonProperty("originalNum")]
        public Nullable<Int32> OriginalNum
        {
            get;
            set;
        }

        [JsonProperty("confirmNum")]
        public Nullable<Int32> ConfirmNum
        {
            get;
            set;
        }

        [JsonProperty("actualNum")]
        public Nullable<Int32> ActualNum
        {
            get;
            set;
        }

        [JsonProperty("nonDeliveryReason")]
        public String NonDeliveryReason
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
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

        [JsonProperty("brandName")]
        public String BrandName
        {
            get;
            set;
        }

        [JsonProperty("brandId")]
        public String BrandId
        {
            get;
            set;
        }

        [JsonProperty("purchaseWareProperty")]
        public PurchaseWarePropertyDto PurchaseWareProperty
        {
            get;
            set;
        }

    }

}
