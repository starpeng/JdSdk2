﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sku
{
﻿    [Serializable]
    public class OrderVenderRemarkQueryByOrderIdResponse : JdResponse
    {
        [JsonProperty("venderRemarkQueryResult")]
        public VenderRemarkQueryResult VenderRemarkQueryResult
        {
            get;
            set;
        }

    }

}
