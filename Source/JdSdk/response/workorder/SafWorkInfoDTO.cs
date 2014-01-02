﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class SafWorkInfoDTO : JdObject
    {
        [JsonProperty("sendBiztypeId")]
        public Nullable<Int64> SendBiztypeId
        {
            get;
            set;
        }

        [JsonProperty("sendBiztypeName")]
        public String SendBiztypeName
        {
            get;
            set;
        }

        [JsonProperty("replyBiztypeName")]
        public String ReplyBiztypeName
        {
            get;
            set;
        }

        [JsonProperty("replySubBiztypeName")]
        public String ReplySubBiztypeName
        {
            get;
            set;
        }

        [JsonProperty("santisfaction")]
        public String Santisfaction
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        [JsonProperty("operLogs")]
        public List<SafWoOperDTO> OperLogs
        {
            get;
            set;
        }

    }

}
