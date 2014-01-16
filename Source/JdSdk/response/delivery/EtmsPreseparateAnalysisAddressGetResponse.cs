﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Delivery.CommonOrderServiceWS;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsPreseparateAnalysisAddressGetResponse : JdResponse
    {
        [JsonProperty("analysisAddressResult")]
        public AnalysisAddressResult AnalysisAddressResult
        {
            get;
            set;
        }

    }

}
