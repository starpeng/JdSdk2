﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareBaseproductGetResponse : JdResponse
    {
        [JsonProperty("product_base")]
        public List<ProductBase> ProductBase
        {
            get;
            set;
        }

    }

}
