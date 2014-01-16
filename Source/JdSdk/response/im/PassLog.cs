﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class PassLog : JdObject
    {
        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        [JsonProperty("loginTime")]
        public Nullable<DateTime> LoginTime
        {
            get;
            set;
        }

        [JsonProperty("logoutTime")]
        public Nullable<DateTime> LogoutTime
        {
            get;
            set;
        }

        [JsonProperty("ip")]
        public String Ip
        {
            get;
            set;
        }

        [JsonProperty("loginSid")]
        public String LoginSid
        {
            get;
            set;
        }

    }

}
