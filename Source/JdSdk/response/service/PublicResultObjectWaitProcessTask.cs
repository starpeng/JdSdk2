﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class PublicResultObjectWaitProcessTask : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("waitProcessAfsService")]
        public PageWaitProcessTask WaitProcessAfsService
        {
            get;
            set;
        }

    }

}
