﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Promotion
{
﻿    [Serializable]
    public class PromotionSearchResponse : JdResponse
    {
        [JsonProperty("promotion_search")]
        public PromotionSearch PromotionSearch
        {
            get;
            set;
        }

    }

}
