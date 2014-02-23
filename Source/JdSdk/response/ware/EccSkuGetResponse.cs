﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class EccSkuGetResponse : JdResponse
    {
        [JsonProperty("item_sku_result")]
        public ItemSkuResult ItemSkuResult
        {
            get;
            set;
        }

    }

}
