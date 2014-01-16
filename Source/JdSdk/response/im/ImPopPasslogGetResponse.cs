﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopPasslogGetResponse : JdResponse
    {
        [JsonProperty("PassLog")]
        public List<PassLog> PassLog
        {
            get;
            set;
        }

    }

}
