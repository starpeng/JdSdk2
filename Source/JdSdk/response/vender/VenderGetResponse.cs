﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Vender;

namespace JdSdk.Response.Vender
{
﻿    [Serializable]
    public class VenderGetResponse : JdResponse
    {
        [JsonProperty("vender")]
        public JdSdk.Domain.Vender.Vender Vender
        {
            get;
            set;
        }

    }

}
