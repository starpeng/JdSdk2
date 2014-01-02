﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Innertest
{
﻿    [Serializable]
    public class AreaIpQueryResponse : JdResponse
    {
        [JsonProperty("jip_response")]
        public IpLookupResponse JipResponse
        {
            get;
            set;
        }

    }

}
