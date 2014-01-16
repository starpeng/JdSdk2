﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sku
{
﻿    [Serializable]
    public class VenderRemarkQueryResult : JdObject
    {
        [JsonProperty("api_jos_result")]
        public ApiJosResult ApiJosResult
        {
            get;
            set;
        }

        [JsonProperty("vender_remark")]
        public VenderRemark VenderRemark
        {
            get;
            set;
        }

    }

}
