﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class WarehouseDetail : JdObject
    {
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        [JsonProperty("warehouse_name")]
        public String WarehouseName
        {
            get;
            set;
        }

        [JsonProperty("warehouse_address")]
        public String WarehouseAddress
        {
            get;
            set;
        }

        [JsonProperty("warehouse_phone")]
        public String WarehousePhone
        {
            get;
            set;
        }

    }

}
