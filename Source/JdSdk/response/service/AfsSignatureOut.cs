﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsSignatureOut : JdObject
    {
        [JsonProperty("opName")]
        public String OpName
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        [JsonProperty("opTime")]
        public Nullable<DateTime> OpTime
        {
            get;
            set;
        }

    }

}
