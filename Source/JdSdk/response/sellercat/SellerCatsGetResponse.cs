﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Sellercat;

namespace JdSdk.Response.Sellercat
{
﻿    [Serializable]
    public class SellerCatsGetResponse : JdResponse
    {
        [JsonProperty("shopCats")]
        public List<ShopCategory> ShopCatList
        {
            get;
            set;
        }

    }

}
