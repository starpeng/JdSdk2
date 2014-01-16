﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Seller.ShopSafService;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class VenderShopQueryResponse : JdResponse
    {
        [JsonProperty("shop_jos_result")]
        public ShopJosResult ShopJosResult
        {
            get;
            set;
        }

    }

}
