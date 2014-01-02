﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Delivery
{
﻿    [Serializable]
    public class EtmsWaybillSendResponse : JdResponse
    {
        [JsonProperty("resultInfo")]
        public SendResultInfoDTO ResultInfo
        {
            get;
            set;
        }

    }

}
