﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Kuaiche.ZnJosPlanService;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnPlanSearchKeywordGetResponse : JdResponse
    {
        [JsonProperty("keywords_info")]
        public List<KeywordVO> KeywordsInfo
        {
            get;
            set;
        }

    }

}
