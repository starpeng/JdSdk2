﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsReturnorderCancelResponse : JdResponse
    {
        [JsonProperty("process_result")]
        public ProcessResult ProcessResult
        {
            get;
            set;
        }

    }

}
