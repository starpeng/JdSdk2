﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KeywordGroup : JdObject
    {
        [JsonProperty("wgroup_id")]
        public Nullable<Int64> WgroupId
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("search_num")]
        public Nullable<Int64> SearchNum
        {
            get;
            set;
        }

        [JsonProperty("base_price")]
        public Nullable<Double> BasePrice
        {
            get;
            set;
        }

        [JsonProperty("avg_price")]
        public Nullable<Double> AvgPrice
        {
            get;
            set;
        }

        [JsonProperty("week_ctr")]
        public Nullable<Double> WeekCtr
        {
            get;
            set;
        }

    }

}
