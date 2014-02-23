﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class EccItemGetResponse : JdResponse
    {
        [JsonProperty("item_proxy_result")]
        public ItemProxyResult ItemProxyResult
        {
            get;
            set;
        }

    }

}
