﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class PublicResultObjectReceiveTask : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("waitReceiveAfsService")]
        public PageReceiveTask WaitReceiveAfsService
        {
            get;
            set;
        }

    }

}
