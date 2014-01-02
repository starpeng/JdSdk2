﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Evaluation
{
﻿    [Serializable]
    public class CommentReply : JdObject
    {
        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

    }

}
