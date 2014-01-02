﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class UserCategory3InfoDto : JdObject
    {
        [JsonProperty("providerCode")]
        public String ProviderCode
        {
            get;
            set;
        }

        [JsonProperty("userCategory3Dtos")]
        public List<UserCategory3Dto> UserCategory3Dtos
        {
            get;
            set;
        }

    }

}
