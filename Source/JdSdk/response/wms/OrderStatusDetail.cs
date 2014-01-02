﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class OrderStatusDetail : JdObject
    {
        [JsonProperty("status")]
        public Nullable<Int32> Status
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

        [JsonProperty("complete_time")]
        public String CompleteTime
        {
            get;
            set;
        }

    }

}
