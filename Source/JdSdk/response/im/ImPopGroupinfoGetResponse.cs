﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopGroupinfoGetResponse : JdResponse
    {
        [JsonProperty("popgroup")]
        public POPGroup Popgroup
        {
            get;
            set;
        }

    }

}
