﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnKeywordgroupListSearchResponse : JdResponse
    {
        [JsonProperty("return_info")]
        public KeywordQueryVO ReturnInfo
        {
            get;
            set;
        }

    }

}
