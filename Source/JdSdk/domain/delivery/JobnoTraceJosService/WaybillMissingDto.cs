﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery.JobnoTraceJosService
{
﻿    [Serializable]
    public class WaybillMissingDto : JdObject
    {
        [JsonProperty("orderCode")]
        public String OrderCode
        {
            get;
            set;
        }

        [JsonProperty("sortSiteCode")]
        public Nullable<Int32> SortSiteCode
        {
            get;
            set;
        }

        [JsonProperty("exceptionCode")]
        public Nullable<Int32> ExceptionCode
        {
            get;
            set;
        }

    }

}
