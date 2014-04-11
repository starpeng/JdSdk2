﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.RefundapplySaf
{
﻿    [Serializable]
    public class RefundapplyResponse : JdObject
    {
        [JsonProperty("count")]
        public Nullable<Int64> Count
        {
            get;
            set;
        }

        [JsonProperty("results")]
        public List<QueryMap> Results
        {
            get;
            set;
        }

        [JsonProperty("result_state")]
        public Nullable<Boolean> ResultState
        {
            get;
            set;
        }

        [JsonProperty("result_info")]
        public String ResultInfo
        {
            get;
            set;
        }

    }

}
