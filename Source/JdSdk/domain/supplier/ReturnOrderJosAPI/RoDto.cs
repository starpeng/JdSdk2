﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Supplier.ReturnOrderJosAPI
{
﻿    [Serializable]
    public class RoDto : JdObject
    {
        [JsonProperty("returnId")]
        public Nullable<Int64> ReturnId
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

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
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

        [JsonProperty("returnStateName")]
        public String ReturnStateName
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

        [JsonProperty("stockName")]
        public String StockName
        {
            get;
            set;
        }

        [JsonProperty("wareHouseAddress")]
        public String WareHouseAddress
        {
            get;
            set;
        }

        [JsonProperty("wareHouseCell")]
        public String WareHouseCell
        {
            get;
            set;
        }

        [JsonProperty("wareHouseContact")]
        public String WareHouseContact
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

        [JsonProperty("wareVariety")]
        public Nullable<Int32> WareVariety
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

    }

}
