﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class SafBiztypeDTO : JdObject
    {
        [JsonProperty("subBiztypeId")]
        public Nullable<Int64> SubBiztypeId
        {
            get;
            set;
        }

        [JsonProperty("subBiztypeName")]
        public String SubBiztypeName
        {
            get;
            set;
        }

    }

}
