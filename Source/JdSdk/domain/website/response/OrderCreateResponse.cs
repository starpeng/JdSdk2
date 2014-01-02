﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Order;

namespace JdSdk.Domain.Website.Response
{
﻿    [Serializable]
    public class OrderCreateResponse : JdResponse
    {
        [JsonProperty("ordercreateresult")]
        public OrderCreateResult OrderCreateResult
        {
            get;
            set;
        }

    }

}
