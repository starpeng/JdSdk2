﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsLog : JdObject
    {
        [JsonProperty("afsLogId")]
        public Nullable<Int32> AfsLogId
        {
            get;
            set;
        }

        [JsonProperty("relationId")]
        public Nullable<Int32> RelationId
        {
            get;
            set;
        }

        [JsonProperty("operateRemark")]
        public String OperateRemark
        {
            get;
            set;
        }

        [JsonProperty("operatePin")]
        public String OperatePin
        {
            get;
            set;
        }

        [JsonProperty("operateName")]
        public String OperateName
        {
            get;
            set;
        }

        [JsonProperty("operateDate")]
        public Nullable<DateTime> OperateDate
        {
            get;
            set;
        }

    }

}
