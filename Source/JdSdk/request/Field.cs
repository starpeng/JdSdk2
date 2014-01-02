﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response;

namespace JdSdk.Request
{
﻿    [Serializable]
    public class Field : JdObject
    {
        [JsonProperty("key")]
        public String Key
        {
            get;
            set;
        }

        [JsonProperty("value")]
        public String Value
        {
            get;
            set;
        }

    }

}
