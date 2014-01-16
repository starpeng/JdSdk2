﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class WosWorklistGetResponse : JdResponse
    {
        [JsonProperty("page")]
        public SafWorkPage Page
        {
            get;
            set;
        }

    }

}
