﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ItemSkuListResult : JdObject
    {
        [JsonProperty("item_sku_result")]
        public List<ItemSkuResult> ItemSkuResult
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

    }

}
