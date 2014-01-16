﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.List
{
﻿    [Serializable]
    public class Items : JdObject
    {
        [JsonProperty("items2")]
        public List<ItemVO> Items2
        {
            get;
            set;
        }

        [JsonProperty("items22")]
        public List<ItemVO2> Items22
        {
            get;
            set;
        }

        [JsonProperty("expandSortValueName")]
        public String ExpandSortValueName
        {
            get;
            set;
        }

    }

}
