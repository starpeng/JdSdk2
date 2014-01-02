﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class ScheduleVOJos : JdObject
    {
        [JsonProperty("show_day")]
        public Nullable<Int32> ShowDay
        {
            get;
            set;
        }

        [JsonProperty("bid_status")]
        public Nullable<Int32> BidStatus
        {
            get;
            set;
        }

    }

}
