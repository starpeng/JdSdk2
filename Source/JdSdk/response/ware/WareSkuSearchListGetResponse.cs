﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareSkuSearchListGetResponse : JdResponse
    {
        [JsonProperty("productSkuList")]
        public ProductSkuList ProductSkuList
        {
            get;
            set;
        }

    }

}
