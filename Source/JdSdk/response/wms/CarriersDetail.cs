﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class CarriersDetail : JdObject
    {
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

        [JsonProperty("carriers_phone")]
        public String CarriersPhone
        {
            get;
            set;
        }

    }

}
