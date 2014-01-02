﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Ware;

namespace JdSdk.Response.Website.Ware
{
﻿    [Serializable]
    public class RegionInfoGetResponse : JdResponse
    {
        [JsonProperty("regions")]
        public List<Region> Regions
        {
            get;
            set;
        }

    }

}
