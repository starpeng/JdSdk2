﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionZoneInfoGetResponse : JdResponse
    {
        [JsonProperty("ad_zone")]
        public AdZoneVo AdZone
        {
            get;
            set;
        }

    }

}
