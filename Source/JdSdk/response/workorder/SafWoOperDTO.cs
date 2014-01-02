﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class SafWoOperDTO : JdObject
    {
        [JsonProperty("operUser")]
        public String OperUser
        {
            get;
            set;
        }

        [JsonProperty("operDate")]
        public Nullable<DateTime> OperDate
        {
            get;
            set;
        }

        [JsonProperty("operType")]
        public String OperType
        {
            get;
            set;
        }

        [JsonProperty("operContent")]
        public String OperContent
        {
            get;
            set;
        }

    }

}
