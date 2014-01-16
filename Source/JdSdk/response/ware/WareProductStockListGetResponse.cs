﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareProductStockListGetResponse : JdResponse
    {
        [JsonProperty("productStock")]
        public ProductStock ProductStock
        {
            get;
            set;
        }

    }

}
