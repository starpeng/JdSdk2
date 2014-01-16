﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareSkuGetResponse : JdResponse
    {
        [JsonProperty("sku")]
        public Domain.Ware.Sku Sku
        {
            get;
            set;
        }
    }
 }
