﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class DataserviceShopuvtop15bydayGetResponse : JdResponse
    {
        [JsonProperty("resultDTO")]
        public ShopUvResultDTO ResultDTO
        {
            get;
            set;
        }

    }

}
