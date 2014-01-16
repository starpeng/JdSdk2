﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionCategoryCommision : JdObject
    {
        [JsonProperty("categoryLevel1Id")]
        public Nullable<Int32> CategoryLevel1Id
        {
            get;
            set;
        }

        [JsonProperty("categoryLevel2Id")]
        public Nullable<Int32> CategoryLevel2Id
        {
            get;
            set;
        }

        [JsonProperty("categoryLevel3Id")]
        public Nullable<Int32> CategoryLevel3Id
        {
            get;
            set;
        }

        [JsonProperty("categoryLevel1Name")]
        public String CategoryLevel1Name
        {
            get;
            set;
        }

        [JsonProperty("categoryLevel2Name")]
        public String CategoryLevel2Name
        {
            get;
            set;
        }

        [JsonProperty("categoryLevel3Name")]
        public String CategoryLevel3Name
        {
            get;
            set;
        }

        [JsonProperty("commisionRatioLevel2")]
        public Nullable<Decimal> CommisionRatioLevel2
        {
            get;
            set;
        }

        [JsonProperty("commisionRatio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

    }

}
