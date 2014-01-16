﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class SellerPromotionSkuListResponse : JdResponse
    {
        [JsonProperty("total_count")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

        [JsonProperty("promo_sku_v_o_s")]
        public List<PromoSkuVO> PromoSkuVOS
        {
            get;
            set;
        }

    }

}
