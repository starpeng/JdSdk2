﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class SellerPromotionPropAddResponse : JdResponse
    {
        [JsonProperty("ids")]
        public List<Int64> Ids
        {
            get;
            set;
        }

    }

}
