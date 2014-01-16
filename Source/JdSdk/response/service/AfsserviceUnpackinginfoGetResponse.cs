﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceProcessFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceUnpackinginfoGetResponse : JdResponse
    {
        [JsonProperty("publicResultObject")]
        public PublicResultObjectUnpackingInfo PublicResultObject
        {
            get;
            set;
        }

    }

}
