﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Im.ApiService
{
﻿    [Serializable]
    public class ChatLogPage : JdObject
    {
        [JsonProperty("chatList")]
        public List<ChatLog> ChatList
        {
            get;
            set;
        }

        [JsonProperty("totalRecord")]
        public Nullable<Int32> TotalRecord
        {
            get;
            set;
        }

    }

}
