﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class Items : JdObject
    {
        [JsonProperty("items")]
        public List<ItemVO> _Items
        {
            get;
            set;
        }

        [JsonProperty("items2")]
        public List<ItemVO2> Items2
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
