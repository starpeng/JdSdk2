﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaichePopGetResponse : JdResponse
    {
        [JsonProperty("result")]
        public PopDetailJos Result
        {
            get;
            set;
        }

    }

}
