﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionAdvdetailGetResponse : JdResponse
    {
        [JsonProperty("adv_detail")]
        public AdvDetailVo AdvDetail
        {
            get;
            set;
        }

    }

}
