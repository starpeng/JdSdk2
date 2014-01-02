﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionZoneCodeGetResponse : JdResponse
    {
        [JsonProperty("zone_code")]
        public String ZoneCode
        {
            get;
            set;
        }

    }

}
