﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionPlanbaseinfoGetResponse : JdResponse
    {
        [JsonProperty("resultVO")]
        public ResultVO ResultVO
        {
            get;
            set;
        }

    }

}
