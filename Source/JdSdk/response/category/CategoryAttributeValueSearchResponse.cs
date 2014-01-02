﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Category;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class CategoryAttributeValueSearchResponse : JdResponse
    {
        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

        [JsonProperty("att_values")]
        public List<AttValue> AttValues
        {
            get;
            set;
        }

    }

}
