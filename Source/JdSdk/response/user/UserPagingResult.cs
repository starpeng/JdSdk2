﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.User
{
﻿    [Serializable]
    public class UserPagingResult : JdObject
    {
        [JsonProperty("users")]
        public List<UserResult> Users
        {
            get;
            set;
        }

        [JsonProperty("total_size")]
        public Nullable<Int32> TotalSize
        {
            get;
            set;
        }

    }

}
