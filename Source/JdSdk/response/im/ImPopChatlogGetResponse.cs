﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Im.ApiService;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopChatlogGetResponse : JdResponse
    {
        [JsonProperty("ChatLog")]
        public ChatLogPage ChatLog
        {
            get;
            set;
        }

    }

}
