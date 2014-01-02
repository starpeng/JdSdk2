﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShoppvtop15bymonthGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopPvResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
