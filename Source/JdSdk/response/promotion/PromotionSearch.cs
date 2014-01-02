﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Promotion
{
﻿    [Serializable]
    public class PromotionSearch : JdObject
    {
        [JsonProperty("promotion_list")]
        public List<Promotion> PromotionList
        {
            get;
            set;
        }

        [JsonProperty("promotion_total")]
        public Nullable<Int32> PromotionTotal
        {
            get;
            set;
        }

    }

}
