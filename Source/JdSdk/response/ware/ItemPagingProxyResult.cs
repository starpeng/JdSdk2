﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ItemPagingProxyResult : JdObject
    {
        [JsonProperty("item_proxy_results")]
        public List<ItemProxyResult> ItemProxyResults
        {
            get;
            set;
        }

        [JsonProperty("total_size")]
        public Nullable<Int32> TotalSize
        {
            get;
            set;
        }

    }

}
