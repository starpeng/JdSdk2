﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.List
{
﻿    [Serializable]
    public class WareProductCatelogyListGetResponse : JdResponse
    {
        [JsonProperty("productCatelogyList")]
        public ProductCatelogyList ProductCatelogyList
        {
            get;
            set;
        }

    }

}
