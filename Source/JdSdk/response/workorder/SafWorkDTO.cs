﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class SafWorkDTO : JdObject
    {
        [JsonProperty("work_id")]
        public Nullable<Int64> WorkId
        {
            get;
            set;
        }

        [JsonProperty("order_id")]
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        [JsonProperty("status_name")]
        public String StatusName
        {
            get;
            set;
        }

        [JsonProperty("create_date")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

    }

}
