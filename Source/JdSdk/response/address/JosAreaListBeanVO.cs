﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Address
{
﻿    [Serializable]
    public class JosAreaListBeanVO : JdObject
    {
        [JsonProperty("province_id")]
        public Nullable<Int64> ProvinceId
        {
            get;
            set;
        }

        [JsonProperty("province_name")]
        public String ProvinceName
        {
            get;
            set;
        }

        [JsonProperty("city_id")]
        public Nullable<Int64> CityId
        {
            get;
            set;
        }

        [JsonProperty("city_name")]
        public String CityName
        {
            get;
            set;
        }

        [JsonProperty("county_id")]
        public Nullable<Int64> CountyId
        {
            get;
            set;
        }

        [JsonProperty("county_name")]
        public String CountyName
        {
            get;
            set;
        }

        [JsonProperty("town_id")]
        public Nullable<Int64> TownId
        {
            get;
            set;
        }

        [JsonProperty("town_name")]
        public String TownName
        {
            get;
            set;
        }

        [JsonProperty("cod")]
        public Nullable<Boolean> Cod
        {
            get;
            set;
        }

    }

}
