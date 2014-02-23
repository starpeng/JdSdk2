﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CmsActivityList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("totalCount")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("cmsActivityLists")]
        public List<CmsActivity> CmsActivityLists
        {
            get;
            set;
        }

    }

}
