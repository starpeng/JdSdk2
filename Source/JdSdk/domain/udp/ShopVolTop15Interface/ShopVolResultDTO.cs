﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Udp.ShopVolTop15Interface
{
﻿    [Serializable]
    public class ShopVolResultDTO : JdObject
    {
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("list")]
        public List<ShopVolTop15Response> List
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
