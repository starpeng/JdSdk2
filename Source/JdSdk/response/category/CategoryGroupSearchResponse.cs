﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Category;

namespace JdSdk.Response.Category
{
﻿    [Serializable]
    public class CategoryGroupSearchResponse : JdResponse
    {
        [JsonProperty("groups")]
        public List<Group> Groups
        {
            get;
            set;
        }

    }

}
