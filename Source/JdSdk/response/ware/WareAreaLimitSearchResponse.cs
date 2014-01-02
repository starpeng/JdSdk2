﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareAreaLimitSearchResponse : JdResponse
    {
        [JsonProperty("ware_area_limits")]
        public List<WareAreaLimit> WareAreaLimits
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

    }

}
