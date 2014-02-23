﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Ware;

namespace JdSdk.Response.Website.Ware
{
﻿    [Serializable]
    public class WareGetResponse : JdResponse
    {
        [JsonProperty("waremodel")]
        public Domain.Website.Ware.Ware WareModel
        {
            get;
            set;
        }
    }
 }
