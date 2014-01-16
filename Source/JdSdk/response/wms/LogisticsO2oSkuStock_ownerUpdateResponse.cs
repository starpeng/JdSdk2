﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Wms.StoreOFCService;

namespace JdSdk.Response.Wms
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
