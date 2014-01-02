﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnScheduleFindScheduleCanUseResponse : JdResponse
    {
        [JsonProperty("scheduleDayList")]
        public List<Int32> ScheduleDayList
        {
            get;
            set;
        }

    }

}
