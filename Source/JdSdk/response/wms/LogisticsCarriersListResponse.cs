﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsCarriersListResponse : JdResponse
    {
        [JsonProperty("carriers_details")]
        public List<CarriersDetail> CarriersDetails
        {
            get;
            set;
        }

    }

}
