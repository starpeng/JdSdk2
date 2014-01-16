﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class ShopSalesResultDTO : JdObject
    {
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("obj")]
        public ShopSalesResponse Obj
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
