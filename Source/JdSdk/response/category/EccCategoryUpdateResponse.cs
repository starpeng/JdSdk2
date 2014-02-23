﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class EccCategoryUpdateResponse : JdResponse
    {
        [JsonProperty("category_result")]
        public Request.Category.CategoryResult CategoryResult
        {
            get;
            set;
        }

    }

}
