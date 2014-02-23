﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallRecommendListGetResponse : JdResponse
    {
        [JsonProperty("mall_recommend_results")]
        public List<MallRecommendResult> MallRecommendResults
        {
            get;
            set;
        }

    }

}
