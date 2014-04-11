﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class ProcurementOrderConfirmResponse : JdResponse
    {
        [JsonProperty("result")]
        public Nullable<Boolean> Result
        {
            get;
            set;
        }

    }

}
