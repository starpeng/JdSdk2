﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheAccountGetResponse : JdResponse
    {
        [JsonProperty("account")]
        public AccountVO Account
        {
            get;
            set;
        }

    }

}
