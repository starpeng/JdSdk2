﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Kuaiche.AccountJosService;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheAccountIncomexpenseSearchResponse : JdResponse
    {
        [JsonProperty("page_info")]
        public PageInfo PageInfo
        {
            get;
            set;
        }

    }

}
