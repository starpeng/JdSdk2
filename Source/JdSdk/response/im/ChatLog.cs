﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ChatLog : JdObject
    {
        [JsonProperty("customer")]
        public String Customer
        {
            get;
            set;
        }

        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

        [JsonProperty("sid")]
        public String Sid
        {
            get;
            set;
        }

        [JsonProperty("skuId")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("time")]
        public Nullable<DateTime> Time
        {
            get;
            set;
        }

        [JsonProperty("channel")]
        public Nullable<Int32> Channel
        {
            get;
            set;
        }

        [JsonProperty("waiterSend")]
        public Nullable<Boolean> WaiterSend
        {
            get;
            set;
        }

    }

}
