﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Category
{
﻿    [Serializable]
    public class AttributeValue : JdObject
    {
        [JsonProperty("vid")]
        public Nullable<Int64> Vid
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

    }

}
