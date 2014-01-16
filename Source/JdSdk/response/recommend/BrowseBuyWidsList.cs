﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Recommend
{
﻿    [Serializable]
    public class BrowseBuyWidsList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("browseBuyWids")]
        public List<CmsActivityWare> BrowseBuyWids
        {
            get;
            set;
        }

    }

}
