﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceConfFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceCategoryGetResponse : JdResponse
    {
        [JsonProperty("publicResultObject")]
        public PublicResultObjectAfsCategory PublicResultObject
        {
            get;
            set;
        }

    }

}
