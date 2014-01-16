﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.List
{
﻿    [Serializable]
    public class CatelogyAttributeList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("expandSorts")]
        public List<Items> ExpandSorts
        {
            get;
            set;
        }

    }

}
