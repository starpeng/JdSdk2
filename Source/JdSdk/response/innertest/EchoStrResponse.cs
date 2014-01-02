﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Innertest
{
﻿    [Serializable]
    public class EchoStrResponse : JdResponse
    {
        [JsonProperty("msg")]
        public String Msg
        {
            get;
            set;
        }

    }

}
