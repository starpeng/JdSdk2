﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class TraceApiDto : JdObject
    {
        [JsonProperty("ope_title")]
        public String OpeTitle
        {
            get;
            set;
        }

        [JsonProperty("ope_remark")]
        public String OpeRemark
        {
            get;
            set;
        }

        [JsonProperty("ope_name")]
        public String OpeName
        {
            get;
            set;
        }

        [JsonProperty("ope_time")]
        public String OpeTime
        {
            get;
            set;
        }

    }

}
