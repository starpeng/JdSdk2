﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Category;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class BrandsGetResponse : JdResponse
    {
        [JsonProperty("brands")]
        public List<AttValue> Brands
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
