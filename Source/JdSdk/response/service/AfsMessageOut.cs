﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsMessageOut : JdObject
    {
        [JsonProperty("afsMessageId")]
        public Nullable<Int32> AfsMessageId
        {
            get;
            set;
        }

        [JsonProperty("afsServiceId")]
        public Nullable<Int32> AfsServiceId
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("context")]
        public String Context
        {
            get;
            set;
        }

    }

}
