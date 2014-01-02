﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceWaitprocesstaskGetResponse : JdResponse
    {
        [JsonProperty("publicResultObject")]
        public PublicResultObjectWaitProcessTask PublicResultObject
        {
            get;
            set;
        }

    }

}
