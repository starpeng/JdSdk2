﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceManagerFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceCustomerfeedbackTransferResponse : JdResponse
    {
        [JsonProperty("customerFeedbackTransferResult")]
        public CustomerFeedbackTransferResult CustomerFeedbackTransferResult
        {
            get;
            set;
        }

    }

}
