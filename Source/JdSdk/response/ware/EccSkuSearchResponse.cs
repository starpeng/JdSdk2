﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class EccSkuSearchResponse : JdResponse
    {
        [JsonProperty("item_sku_result_list")]
        public ItemSkuListResult ItemSkuResultList
        {
            get;
            set;
        }

    }

}
