﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallRecommendUpdateResponse : JdResponse
    {
        [JsonProperty("mall_recommend_result")]
        public MallRecommendResult MallRecommendResult
        {
            get;
            set;
        }

    }

}
