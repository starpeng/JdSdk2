﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Category
{
﻿    [Serializable]
    public class WareAttribute : JdObject
    {
        [JsonProperty("aid")]
        public Nullable<Int64> Aid
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

        [JsonProperty("attribute_values")]
        public List<AttributeValue> AttributeValues
        {
            get;
            set;
        }

    }

}
