﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoTraceJosService
{
﻿    [Serializable]
    public class OrderInfoDto : JdObject
    {
        [JsonProperty("validateStr")]
        public String ValidateStr
        {
            get;
            set;
        }

        [JsonProperty("partnerAliases")]
        public String PartnerAliases
        {
            get;
            set;
        }

        [JsonProperty("exceptionCode")]
        public Nullable<Int32> ExceptionCode
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

        [JsonProperty("orderCode")]
        public String OrderCode
        {
            get;
            set;
        }

        [JsonProperty("provinceName")]
        public String ProvinceName
        {
            get;
            set;
        }

        [JsonProperty("cityName")]
        public String CityName
        {
            get;
            set;
        }

        [JsonProperty("countryName")]
        public String CountryName
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

        [JsonProperty("receiverAddress")]
        public String ReceiverAddress
        {
            get;
            set;
        }

        [JsonProperty("receiverMobile")]
        public String ReceiverMobile
        {
            get;
            set;
        }

        [JsonProperty("receiverZipCode")]
        public String ReceiverZipCode
        {
            get;
            set;
        }

        [JsonProperty("codMoney")]
        public String CodMoney
        {
            get;
            set;
        }

        [JsonProperty("sortSiteName")]
        public String SortSiteName
        {
            get;
            set;
        }

        [JsonProperty("orgName")]
        public String OrgName
        {
            get;
            set;
        }

        [JsonProperty("goodNumber")]
        public Nullable<Int32> GoodNumber
        {
            get;
            set;
        }

        [JsonProperty("sortSiteId")]
        public Nullable<Int32> SortSiteId
        {
            get;
            set;
        }

    }

}
