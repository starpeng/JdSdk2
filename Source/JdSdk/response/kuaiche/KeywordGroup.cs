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
        [JsonProperty("wgroupId")]
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

        [JsonProperty("categoryId")]
        public String CategoryId
        {
            get;
            set;
        }

        [JsonProperty("searchNum")]
        public Nullable<Int64> SearchNum
        {
            get;
            set;
        }

        [JsonProperty("basePrice")]
        public Nullable<Decimal> BasePrice
        {
            get;
            set;
        }

        [JsonProperty("avgPrice")]
        public Nullable<Decimal> AvgPrice
        {
            get;
            set;
        }

        [JsonProperty("avgDealPrice")]
        public Nullable<Decimal> AvgDealPrice
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

    }

}
