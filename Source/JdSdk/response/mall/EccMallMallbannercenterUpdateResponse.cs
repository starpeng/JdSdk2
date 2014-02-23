﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallMallbannercenterUpdateResponse : JdResponse
    {
        [JsonProperty("mall_banner_result")]
        public MallBannerResult MallBannerResult
        {
            get;
            set;
        }

    }

}
