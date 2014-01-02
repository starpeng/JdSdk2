﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Tools
{
﻿    [Serializable]
    public class TimeGetResponse : JdResponse
    {
        [JsonProperty("time")]
        public String Time
        {
            get;
            set;
        }

    }

}
