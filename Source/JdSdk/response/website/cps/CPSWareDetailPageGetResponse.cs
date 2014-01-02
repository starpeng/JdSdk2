﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Cps;

namespace JdSdk.Response.Website.Cps
{
﻿    [Serializable]
    public class CPSWareDetailPageGetResponse : JdResponse
    {
        [JsonProperty("total_count")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("tuiguang_wares_details")]
        public List<PromoteWareDetail> WareDetailList
        {
            get;
            set;
        }

    }

}
