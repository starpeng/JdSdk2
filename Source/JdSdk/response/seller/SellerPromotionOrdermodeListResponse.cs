﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class SellerPromotionOrdermodeListResponse : JdResponse
    {
        [JsonProperty("promo_order_mode_v_os")]
        public List<OrderModeVO> PromoOrderModeVOs
        {
            get;
            set;
        }

    }

}
