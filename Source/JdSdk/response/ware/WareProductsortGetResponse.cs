﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareProductsortGetResponse : JdResponse
    {
        [JsonProperty("product_sorts")]
        public List<ProductSort> ProductSorts
        {
            get;
            set;
        }

    }

}
