﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsStockSearchResponse : JdResponse
    {
        [JsonProperty("stock")]
        public ResponseStock Stock
        {
            get;
            set;
        }

    }

}
