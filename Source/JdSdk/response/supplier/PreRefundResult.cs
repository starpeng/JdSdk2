﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class PreRefundResult : JdObject
    {
        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

    }

}
