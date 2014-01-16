﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopChatlogFuzzyQueryResponse : JdResponse
    {
        [JsonProperty("ChatLog")]
        public List<ChatLog> ChatLog
        {
            get;
            set;
        }

    }

}
