﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Zhijian.QTReportService;

namespace JdSdk.Response.Zhijian
{
﻿    [Serializable]
    public class MarketServiceQtReportAddResponse : JdResponse
    {
        [JsonProperty("publicResult")]
        public AddResult PublicResult
        {
            get;
            set;
        }

    }

}
