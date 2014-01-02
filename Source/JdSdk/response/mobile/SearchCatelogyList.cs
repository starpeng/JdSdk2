﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class SearchCatelogyList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("wareCount")]
        public Nullable<Int32> WareCount
        {
            get;
            set;
        }

        [JsonProperty("page")]
        public Nullable<Int32> Page
        {
            get;
            set;
        }

        [JsonProperty("regionIsTrue")]
        public Nullable<Boolean> RegionIsTrue
        {
            get;
            set;
        }

        [JsonProperty("selfIsTrue")]
        public Nullable<Boolean> SelfIsTrue
        {
            get;
            set;
        }

        [JsonProperty("show")]
        public String Show
        {
            get;
            set;
        }

        [JsonProperty("wareInfo")]
        public List<WareInfo> WareInfo
        {
            get;
            set;
        }

    }

}
