﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WarePromotionSearchCatelogyListResponse : JdResponse
    {
        [JsonProperty("searchCatelogyList")]
        public SearchCatelogyList SearchCatelogyList
        {
            get;
            set;
        }

    }

}
