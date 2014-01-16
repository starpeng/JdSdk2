﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceManagerFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceFreightUpdateResponse : JdResponse
    {
        [JsonProperty("afsFreightUpdateResult")]
        public AfsFreightUpdateResult AfsFreightUpdateResult
        {
            get;
            set;
        }

    }

}
