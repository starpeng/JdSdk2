﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Zhijian.QTReportService
{
﻿    [Serializable]
    public class GetResult : JdObject
    {
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        [JsonProperty("r_code")]
        public String RCode
        {
            get;
            set;
        }

        [JsonProperty("r_msg")]
        public String RMsg
        {
            get;
            set;
        }

        [JsonProperty("model")]
        public QTReportVO Model
        {
            get;
            set;
        }

    }

}
