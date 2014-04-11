﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class VcCreateReturnOrderResponse : JdResponse
    {
        [JsonProperty("returnOrderIds")]
        public List<Int32[]> ReturnOrderIds
        {
            get;
            set;
        }

    }

}
