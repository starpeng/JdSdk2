﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Evaluation
{
﻿    [Serializable]
    public class CommentVo : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("nickname")]
        public String Nickname
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

        [JsonProperty("score")]
        public Nullable<Int32> Score
        {
            get;
            set;
        }

        [JsonProperty("creationTime")]
        public Nullable<DateTime> CreationTime
        {
            get;
            set;
        }

        [JsonProperty("replies")]
        public List<CommentReply> Replies
        {
            get;
            set;
        }

    }

}
