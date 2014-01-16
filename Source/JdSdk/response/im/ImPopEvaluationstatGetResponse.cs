﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopEvaluationstatGetResponse : JdResponse
    {
        [JsonProperty("WaiterDailyEvaStat")]
        public List<WaiterDailyEvaStat> WaiterDailyEvaStat
        {
            get;
            set;
        }

    }

}
