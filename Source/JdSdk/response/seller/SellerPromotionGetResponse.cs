﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class SellerPromotionGetResponse : JdResponse
    {
        [JsonProperty("promotion_v_o")]
        public PromotionVO PromotionVO
        {
            get;
            set;
        }

    }

}
