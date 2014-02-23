﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mall
{
﻿    [Serializable]
    public class EccMallMallinfocenterUpdateResponse : JdResponse
    {
        [JsonProperty("mall_info_result")]
        public MallInfoResult MallInfoResult
        {
            get;
            set;
        }

    }

}
