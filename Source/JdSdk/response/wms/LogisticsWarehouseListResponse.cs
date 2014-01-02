﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsWarehouseListResponse : JdResponse
    {
        [JsonProperty("warehouse_details")]
        public List<WarehouseDetail> WarehouseDetails
        {
            get;
            set;
        }

    }

}
