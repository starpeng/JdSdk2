﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallMallbannercenterSearchResponse : JdResponse
    {
        [JsonProperty("mall_banner_results")]
        public List<MallBannerResult> MallBannerResults
        {
            get;
            set;
        }

    }

}
