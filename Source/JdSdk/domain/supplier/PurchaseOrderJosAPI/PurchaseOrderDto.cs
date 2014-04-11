﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.PurchaseOrderJosAPI
{
﻿    [Serializable]
    public class PurchaseOrderDto : JdObject
    {
        [JsonProperty("orderId")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        [JsonProperty("createdDate")]
        public Nullable<DateTime> CreatedDate
        {
            get;
            set;
        }

        [JsonProperty("completeDate")]
        public Nullable<DateTime> CompleteDate
        {
            get;
            set;
        }

        [JsonProperty("providerCode")]
        public String ProviderCode
        {
            get;
            set;
        }

        [JsonProperty("providerName")]
        public String ProviderName
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

        [JsonProperty("totalPrices")]
        public Nullable<Decimal> TotalPrices
        {
            get;
            set;
        }

        [JsonProperty("purchaserErpCode")]
        public String PurchaserErpCode
        {
            get;
            set;
        }

        [JsonProperty("purchaserName")]
        public String PurchaserName
        {
            get;
            set;
        }

        [JsonProperty("isCanConfirm")]
        public Nullable<Boolean> IsCanConfirm
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        [JsonProperty("statusName")]
        public String StatusName
        {
            get;
            set;
        }

        [JsonProperty("accountPeriod")]
        public Nullable<Int32> AccountPeriod
        {
            get;
            set;
        }

        [JsonProperty("ou")]
        public String Ou
        {
            get;
            set;
        }

        [JsonProperty("ynPaid")]
        public String YnPaid
        {
            get;
            set;
        }

        [JsonProperty("ynContainTax")]
        public String YnContainTax
        {
            get;
            set;
        }

        [JsonProperty("chargeTransit")]
        public String ChargeTransit
        {
            get;
            set;
        }

        [JsonProperty("transitType")]
        public String TransitType
        {
            get;
            set;
        }

        [JsonProperty("arrivalDays")]
        public Nullable<Int32> ArrivalDays
        {
            get;
            set;
        }

        [JsonProperty("checkType")]
        public Nullable<Int32> CheckType
        {
            get;
            set;
        }

        [JsonProperty("checkTypeName")]
        public String CheckTypeName
        {
            get;
            set;
        }

        [JsonProperty("deliveryAddress")]
        public String DeliveryAddress
        {
            get;
            set;
        }

        [JsonProperty("receiverName")]
        public String ReceiverName
        {
            get;
            set;
        }

        [JsonProperty("warehousePhone")]
        public String WarehousePhone
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public String Address
        {
            get;
            set;
        }

        [JsonProperty("purchaseType")]
        public Nullable<Int32> PurchaseType
        {
            get;
            set;
        }

        [JsonProperty("purchaseTypeName")]
        public String PurchaseTypeName
        {
            get;
            set;
        }

        [JsonProperty("orderType")]
        public Nullable<Int32> OrderType
        {
            get;
            set;
        }

        [JsonProperty("orderTypeName")]
        public String OrderTypeName
        {
            get;
            set;
        }

        [JsonProperty("orderAttribute")]
        public Nullable<Int32> OrderAttribute
        {
            get;
            set;
        }

        [JsonProperty("orderAttributeName")]
        public String OrderAttributeName
        {
            get;
            set;
        }

        [JsonProperty("originalTotalNum")]
        public Nullable<Int32> OriginalTotalNum
        {
            get;
            set;
        }

        [JsonProperty("wareVariety")]
        public Nullable<Int32> WareVariety
        {
            get;
            set;
        }

        [JsonProperty("customOrderId")]
        public Nullable<Int32> CustomOrderId
        {
            get;
            set;
        }

        [JsonProperty("confirmState")]
        public Nullable<Int32> ConfirmState
        {
            get;
            set;
        }

        [JsonProperty("confirmStateName")]
        public String ConfirmStateName
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public Nullable<Int32> State
        {
            get;
            set;
        }

        [JsonProperty("stateName")]
        public String StateName
        {
            get;
            set;
        }

    }

}
