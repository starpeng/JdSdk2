﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class PacksList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("imageDomain")]
        public String ImageDomain
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public List<Packs> Data
        {
            get;
            set;
        }

    }

}
