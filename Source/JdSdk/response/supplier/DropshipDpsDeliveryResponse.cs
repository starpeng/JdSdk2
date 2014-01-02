﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class DropshipDpsDeliveryResponse : JdResponse
    {
        [JsonProperty("deliverResult")]
        public DeliverDoResultSetDto DeliverResult
        {
            get;
            set;
        }

    }

}
