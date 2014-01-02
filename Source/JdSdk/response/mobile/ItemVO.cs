﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class ItemVO : JdObject
    {
        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        [JsonProperty("expandSortsList")]
        public List<ExpandSorts> ExpandSortsList
        {
            get;
            set;
        }

    }

}
