﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderOrderDeleteApplyResponse : JdResponse
    {
        [JsonProperty("result")]
        public ApiJosResult Result
        {
            get;
            set;
        }

    }

}
