﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class SellerPromotionResumeResponse : JdResponse
    {
        [JsonProperty("count")]
        public Nullable<Int32> Count
        {
            get;
            set;
        }

    }

}
