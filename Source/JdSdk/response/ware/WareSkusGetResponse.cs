﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareSkusGetResponse : JdResponse
    {
        [JsonProperty("skus")]
        public List<Sku> Skus
        {
            get;
            set;
        }

    }

}
