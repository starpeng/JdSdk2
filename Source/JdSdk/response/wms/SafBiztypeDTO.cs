﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class SafBiztypeDTO : JdObject
    {
        [JsonProperty("sub_biztype_id")]
        public Nullable<Int64> SubBiztypeId
        {
            get;
            set;
        }

        [JsonProperty("sub_biztype_name")]
        public String SubBiztypeName
        {
            get;
            set;
        }

    }

}
