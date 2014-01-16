﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceProcessFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceHistoryGetResponse : JdResponse
    {
        [JsonProperty("publicResultList")]
        public PublicResultListAfsServiceHistory PublicResultList
        {
            get;
            set;
        }

    }

}
