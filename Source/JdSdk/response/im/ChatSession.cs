﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ChatSession : JdObject
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

        [JsonProperty("beginTime")]
        public Nullable<DateTime> BeginTime
        {
            get;
            set;
        }

        [JsonProperty("replyTime")]
        public Nullable<DateTime> ReplyTime
        {
            get;
            set;
        }

        [JsonProperty("endTime")]
        public Nullable<DateTime> EndTime
        {
            get;
            set;
        }

        [JsonProperty("sessionType")]
        public Nullable<Int32> SessionType
        {
            get;
            set;
        }

        [JsonProperty("transfer")]
        public Nullable<Boolean> Transfer
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
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

    }

}
