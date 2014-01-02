﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareSkuAddResponse : JdResponse
    {
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

    }

}
