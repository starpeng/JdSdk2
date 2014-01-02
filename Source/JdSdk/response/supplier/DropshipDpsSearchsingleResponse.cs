﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class DropshipDpsSearchsingleResponse : JdResponse
    {
        [JsonProperty("searchSingleResult")]
        public QuerySingleOrderForJosResultDto SearchSingleResult
        {
            get;
            set;
        }

    }

}
