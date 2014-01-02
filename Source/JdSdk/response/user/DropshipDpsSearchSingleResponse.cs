﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.User
{
﻿    [Serializable]
    public class DropshipDpsSearchSingleResponse : JdResponse
    {
        [JsonProperty("searchSingleResult")]
        public Result SearchSingleResult
        {
            get;
            set;
        }

    }

}
