﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsReturnorderQueryResponse : JdResponse
    {
        [JsonProperty("response_return_order")]
        public ResponseReturnOrder ResponseReturnOrder
        {
            get;
            set;
        }

    }

}
