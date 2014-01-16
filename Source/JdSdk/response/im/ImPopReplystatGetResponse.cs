﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopReplystatGetResponse : JdResponse
    {
        [JsonProperty("WaiterDailyStat")]
        public List<WaiterDailyStat> WaiterDailyStat
        {
            get;
            set;
        }

    }

}
