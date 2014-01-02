﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnBidRankGetResponse : JdResponse
    {
        [JsonProperty("rank_return")]
        public RankReturnJO RankReturn
        {
            get;
            set;
        }

    }

}
