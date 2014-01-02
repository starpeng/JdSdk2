﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class LogisticsO2oOrderCarriageResponse : JdResponse
    {
        [JsonProperty("OrderExport")]
        public OrderExportResponse OrderExport
        {
            get;
            set;
        }

    }

}
