﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class SellerPromotionPropListResponse : JdResponse
    {
        [JsonProperty("promo_prop_v_o_s")]
        public List<PromoPropVO> PromoPropVOS
        {
            get;
            set;
        }

    }

}
