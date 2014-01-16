﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceManagerFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceReturnCancelResponse : JdResponse
    {
        [JsonProperty("returnCancelResult")]
        public ReturnCancelResult ReturnCancelResult
        {
            get;
            set;
        }

    }

}
