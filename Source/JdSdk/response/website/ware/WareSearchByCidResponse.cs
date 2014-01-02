﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Ware;

namespace JdSdk.Response.Website.Ware
{
﻿    [Serializable]
    public class WareSearchByCidResponse : JdResponse
    {
        [JsonProperty("ware_infos")]
        public List<JdSdk.Domain.Website.Ware.Ware> WareInfos
        {
            get;
            set;
        }

    }

}
