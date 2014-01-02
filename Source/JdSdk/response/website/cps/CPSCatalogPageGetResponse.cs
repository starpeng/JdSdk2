﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Cps;

namespace JdSdk.Response.Website.Cps
{
﻿    [Serializable]
    public class CPSCatalogPageGetResponse : JdResponse
    {
        [JsonProperty("tuiguang_wares")]
        public List<PromoteWare> PromoteWares
        {
            get;
            set;
        }

    }

}
