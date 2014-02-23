﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.O2O.StoreOFCService;

namespace JdSdk.Response.O2O
{
﻿    [Serializable]
    public class LogisticsO2oSkuStockOwnerUpdateResponse : JdResponse
    {
        [JsonProperty("SkuAddResponse")]
        public SkuAddResponse SkuAddResponse
        {
            get;
            set;
        }

    }

}
