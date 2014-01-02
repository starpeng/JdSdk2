﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class DropshipDpsRefuseResponse : JdResponse
    {
        [JsonProperty("refuseResult")]
        public RefuseResult RefuseResult
        {
            get;
            set;
        }

    }

}
