﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class UserCategory3InfoGetResponse : JdResponse
    {
        [JsonProperty("userCategory3Info")]
        public UserCategory3InfoDto UserCategory3Info
        {
            get;
            set;
        }

    }

}
