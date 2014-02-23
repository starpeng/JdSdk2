﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class EccCategoryDeleteResponse : JdResponse
    {
        [JsonProperty("is_success")]
        public Nullable<Boolean> IsSuccess
        {
            get;
            set;
        }

    }

}
