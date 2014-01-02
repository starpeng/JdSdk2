﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Cps;

namespace JdSdk.Response.Website.Cps
{
﻿    [Serializable]
    public class CPSSpreadHomeInfoResponse : JdResponse
    {
        [JsonProperty("home_page_info")]
        public CPSSpreadHomeInfoModule HomeInfoModule
        {
            get;
            set;
        }

    }

}
