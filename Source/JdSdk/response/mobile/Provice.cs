﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class Provice : JdObject
    {
        [JsonProperty("label")]
        public String Label
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
