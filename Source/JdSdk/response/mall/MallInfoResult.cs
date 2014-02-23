﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class MallInfoResult : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("seller_id")]
        public Nullable<Int64> SellerId
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

        [JsonProperty("logo")]
        public String Logo
        {
            get;
            set;
        }

    }

}
