﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderUserInfo : JdObject
    {
        [JsonProperty("full_name")]
        public String FullName
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

    }

}
