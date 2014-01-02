﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionReportOverviewSearchResponse : JdResponse
    {
        [JsonProperty("data")]
        public List<OverviewVo> Data
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

        [JsonProperty("page_total")]
        public Nullable<Int64> PageTotal
        {
            get;
            set;
        }

        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        [JsonProperty("end_date")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

    }

}
