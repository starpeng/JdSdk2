﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class WorkOrderResponse : JdObject
    {
        [JsonProperty("result_code")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("result_msg")]
        public String ResultMsg
        {
            get;
            set;
        }

    }

}
