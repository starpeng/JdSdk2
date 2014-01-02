﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionReportWindowSearchResponse : JdResponse
    {
        [JsonProperty("datas")]
        public List<WindowAdvDetail> Datas
        {
            get;
            set;
        }

        [JsonProperty("page_index")]
        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        [JsonProperty("page_size")]
        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }

}
