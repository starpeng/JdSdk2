﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Evaluation
{
﻿    [Serializable]
    public class Consultation : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int32> Id
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

        [JsonProperty("nickName")]
        public String NickName
        {
            get;
            set;
        }

        [JsonProperty("userLevelId")]
        public String UserLevelId
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

        [JsonProperty("reply")]
        public Reply Reply
        {
            get;
            set;
        }

    }

}
