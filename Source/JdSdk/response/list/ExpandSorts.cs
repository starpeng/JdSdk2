﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.List
{
﻿    [Serializable]
    public class ExpandSorts : JdObject
    {
        [JsonProperty("expandValueId")]
        public Nullable<Int32> ExpandValueId
        {
            get;
            set;
        }

        [JsonProperty("expandSortValueName")]
        public String ExpandSortValueName
        {
            get;
            set;
        }

    }

}
