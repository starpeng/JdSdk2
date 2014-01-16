﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.User
{
﻿    [Serializable]
    public class EccUserGetResponse : JdResponse
    {
        [JsonProperty("user_result")]
        public UserResult UserResult
        {
            get;
            set;
        }

    }

}
