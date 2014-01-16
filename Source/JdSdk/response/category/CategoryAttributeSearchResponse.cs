﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class CategoryAttributeSearchResponse : JdResponse
    {
        [JsonProperty("attributes")]
        public List<Attribute> Attributes
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

    }

}
