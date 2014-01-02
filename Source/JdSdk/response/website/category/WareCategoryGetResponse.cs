﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Category;

namespace JdSdk.Response.Website.Category
{
﻿    [Serializable]
    public class WareCategoryGetResponse : JdResponse
    {
        [JsonProperty("warecategories")]
        public List<WareCategory> WareCategories
        {
            get;
            set;
        }

    }

}
