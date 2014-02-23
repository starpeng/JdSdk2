﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallRecommendDeleteResponse : JdResponse
    {
        [JsonProperty("mall_recomment_result")]
        public MallRecommendResult MallRecommendResult
        {
            get;
            set;
        }

    }

}
