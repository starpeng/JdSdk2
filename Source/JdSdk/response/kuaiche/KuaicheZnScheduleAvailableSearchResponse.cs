﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnScheduleAvailableSearchResponse : JdResponse
    {
        [JsonProperty("schedule_day_list")]
        public List<Int32> ScheduleDayList
        {
            get;
            set;
        }

    }

}
