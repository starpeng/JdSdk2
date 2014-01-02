﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionPromotiongoodQueryResponse : JdResponse
    {
        [JsonProperty("good_list")]
        public List<GoodSafVo> GoodList
        {
            get;
            set;
        }

        [JsonProperty("totalCount")]
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("isDefault")]
        public Nullable<Boolean> IsDefault
        {
            get;
            set;
        }

    }

}
