﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class UserInfo : JdObject
    {
        [JsonProperty("fullname")]
        public String Fullname
        {
            get;
            set;
        }

        [JsonProperty("telephone")]
        public String Telephone
        {
            get;
            set;
        }

        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        [JsonProperty("full_address")]
        public String FullAddress
        {
            get;
            set;
        }

        [JsonProperty("province")]
        public String Province
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public String City
        {
            get;
            set;
        }

        [JsonProperty("county")]
        public String County
        {
            get;
            set;
        }

    }

}
