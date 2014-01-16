﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopSessionlistGetResponse : JdResponse
    {
        [JsonProperty("ChatSession")]
        public List<ChatSession> ChatSession
        {
            get;
            set;
        }

    }

}
