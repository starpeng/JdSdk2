﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class SafWorkPage : JdObject
    {
        [JsonProperty("result")]
        public List<SafWorkDTO> Result
        {
            get;
            set;
        }

        [JsonProperty("total_count")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

    }

}
