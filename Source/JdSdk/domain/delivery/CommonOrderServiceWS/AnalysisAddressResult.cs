﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.CommonOrderServiceWS
{
﻿    [Serializable]
    public class AnalysisAddressResult : JdObject
    {
        [JsonProperty("provinceId")]
        public Nullable<Int32> ProvinceId
        {
            get;
            set;
        }

        [JsonProperty("cityId")]
        public Nullable<Int32> CityId
        {
            get;
            set;
        }

        [JsonProperty("countyId")]
        public Nullable<Int32> CountyId
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

        [JsonProperty("countyName")]
        public String CountyName
        {
            get;
            set;
        }

        [JsonProperty("fullAddress")]
        public String FullAddress
        {
            get;
            set;
        }

        [JsonProperty("analysisState")]
        public Nullable<Int32> AnalysisState
        {
            get;
            set;
        }

    }

}
