﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Udp.ShopSalesTop15Interface
{
﻿    [Serializable]
    public class ShopSalesTop15ResultDTO : JdObject
    {
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public List<ShopSalesTop15Response> List
        {
            get;
            set;
        }

        [JsonProperty("totalSize")]
        public Nullable<Int64> TotalSize
        {
            get;
            set;
        }

    }

}
