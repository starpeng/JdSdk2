﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class ActivityModeVO : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("promo_id")]
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        [JsonProperty("num_bound")]
        public Nullable<Int32> NumBound
        {
            get;
            set;
        }

        [JsonProperty("freq_bound")]
        public Nullable<Int32> FreqBound
        {
            get;
            set;
        }

        [JsonProperty("per_max_num")]
        public Nullable<Int32> PerMaxNum
        {
            get;
            set;
        }

        [JsonProperty("per_min_num")]
        public Nullable<Int32> PerMinNum
        {
            get;
            set;
        }

    }

}
