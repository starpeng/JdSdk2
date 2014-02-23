﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class EccCategoryParentsListGetResponse : JdResponse
    {
        [JsonProperty("categorys")]
        public List<Request.Category.CategoryResult> Categorys
        {
            get;
            set;
        }

    }

}
