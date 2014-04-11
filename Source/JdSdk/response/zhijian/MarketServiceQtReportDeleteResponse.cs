﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Zhijian.QTReportService;

namespace JdSdk.Response.Zhijian
{
﻿    [Serializable]
    public class MarketServiceQtReportDeleteResponse : JdResponse
    {
        [JsonProperty("publicResult")]
        public ReportDeleteResult PublicResult
        {
            get;
            set;
        }

    }

}
