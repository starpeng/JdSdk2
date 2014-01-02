﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Ware
{
﻿    [Serializable]
    public class Region : JdObject
    {
        [JsonProperty("region_id")]
        public Nullable<Int64> RegionId
        {
            get;
            set;
        }

        [JsonProperty("region_name")]
        public String ResionName
        {
            get;
            set;
        }

    }

}
