﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.ReturnOrderJosAPI
{
﻿    [Serializable]
    public class DetailResultDto : JdObject
    {
        [JsonProperty("returnId")]
        public Nullable<Int64> ReturnId
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
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

        [JsonProperty("fromDeliverCenterName")]
        public String FromDeliverCenterName
        {
            get;
            set;
        }

        [JsonProperty("toDeliverCenterName")]
        public String ToDeliverCenterName
        {
            get;
            set;
        }

        [JsonProperty("totalNum")]
        public Nullable<Int32> TotalNum
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

        [JsonProperty("wareVariety")]
        public Nullable<Int32> WareVariety
        {
            get;
            set;
        }

        [JsonProperty("bookingDate")]
        public Nullable<DateTime> BookingDate
        {
            get;
            set;
        }

        [JsonProperty("deliverTime")]
        public Nullable<DateTime> DeliverTime
        {
            get;
            set;
        }

        [JsonProperty("balanceState")]
        public Nullable<Int32> BalanceState
        {
            get;
            set;
        }

        [JsonProperty("balanceStateName")]
        public String BalanceStateName
        {
            get;
            set;
        }

        [JsonProperty("balanceDate")]
        public Nullable<DateTime> BalanceDate
        {
            get;
            set;
        }

        [JsonProperty("opinion")]
        public String Opinion
        {
            get;
            set;
        }

        [JsonProperty("outStoreRoomDate")]
        public Nullable<DateTime> OutStoreRoomDate
        {
            get;
            set;
        }

        [JsonProperty("detailDtoList")]
        public List<RoDetailDto> DetailDtoList
        {
            get;
            set;
        }

    }

}
