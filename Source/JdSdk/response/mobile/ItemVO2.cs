﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class ItemVO2 : JdObject
    {
        [JsonProperty("expandSortsList2")]
        public List<ExpandSorts> ExpandSortsList2
        {
            get;
            set;
        }

    }

}
