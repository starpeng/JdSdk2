﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class ActivityImageCode : JdObject
    {
        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

    }

}
