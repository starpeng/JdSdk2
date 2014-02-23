﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class ShopPvResultDTO : JdObject
    {
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public List<ShopPvTop15Response> List
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
