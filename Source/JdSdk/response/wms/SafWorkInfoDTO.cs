﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class SafWorkInfoDTO : JdObject
    {
        [JsonProperty("send_biztype_id")]
        public Nullable<Int64> SendBiztypeId
        {
            get;
            set;
        }

        [JsonProperty("send_biztype_name")]
        public String SendBiztypeName
        {
            get;
            set;
        }

        [JsonProperty("reply_biztype_name")]
        public String ReplyBiztypeName
        {
            get;
            set;
        }

        [JsonProperty("reply_sub_biztype_name")]
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

        [JsonProperty("create_date")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        [JsonProperty("oper_logs")]
        public List<SafWoOperDTO> OperLogs
        {
            get;
            set;
        }

    }

}
