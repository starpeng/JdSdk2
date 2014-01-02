﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsRefundInfoOut : JdObject
    {
        [JsonProperty("afsFinanceDetailOuts")]
        public List<AfsFinanceDetailOut> AfsFinanceDetailOuts
        {
            get;
            set;
        }

        [JsonProperty("afsSignatureOut")]
        public List<AfsSignatureOut> AfsSignatureOut
        {
            get;
            set;
        }

        [JsonProperty("afsFinanceOut")]
        public AfsFinanceOut AfsFinanceOut
        {
            get;
            set;
        }

        [JsonProperty("afsRefundOut")]
        public AfsRefundOut AfsRefundOut
        {
            get;
            set;
        }

    }

}
