﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sku
{
﻿    [Serializable]
    public class OrderOrderDeleteCancelApplyResponse : JdResponse
    {
        [JsonProperty("result")]
        public ApiJosResult Result
        {
            get;
            set;
        }

    }

}
