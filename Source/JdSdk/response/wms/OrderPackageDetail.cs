﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class OrderPackageDetail : JdObject
    {
        [JsonProperty("weight")]
        public String Weight
        {
            get;
            set;
        }

        [JsonProperty("delivery_no")]
        public String DeliveryNo
        {
            get;
            set;
        }

        [JsonProperty("carriers_id")]
        public String CarriersId
        {
            get;
            set;
        }

        [JsonProperty("carriers_name")]
        public String CarriersName
        {
            get;
            set;
        }

    }

}
