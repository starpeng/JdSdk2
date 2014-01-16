﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.User
{
﻿    [Serializable]
    public class EccUserSearchResponse : JdResponse
    {
        [JsonProperty("user_paging_result")]
        public UserPagingResult UserPagingResult
        {
            get;
            set;
        }

    }

}
