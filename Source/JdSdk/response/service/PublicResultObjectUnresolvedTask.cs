﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class PublicResultObjectUnresolvedTask : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("unresolvedAfsService")]
        public PageUnresolvedTask UnresolvedAfsService
        {
            get;
            set;
        }

    }

}
