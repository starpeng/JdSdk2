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
        [JsonProperty("oper_user")]
        public String OperUser
        {
            get;
            set;
        }

        [JsonProperty("oper_date")]
        public Nullable<DateTime> OperDate
        {
            get;
            set;
        }

        [JsonProperty("oper_type")]
        public String OperType
        {
            get;
            set;
        }

        [JsonProperty("oper_content")]
        public String OperContent
        {
            get;
            set;
        }

    }

}
