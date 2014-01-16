﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Service.AfsServiceManagerFacade
{
﻿    [Serializable]
    public class PageWaitFetch : JdObject
    {
        [JsonProperty("totalCount")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("result")]
        public List<AfsPopApplyFetchWaitFetch> Result
        {
            get;
            set;
        }

    }

}
