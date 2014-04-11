﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Kuaiche.AccountJosService;

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
