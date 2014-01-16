﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Seller.ShopSafService
{
﻿    [Serializable]
    public class ShopJosResult : JdObject
    {
        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        [JsonProperty("open_time")]
        public Nullable<DateTime> OpenTime
        {
            get;
            set;
        }

        [JsonProperty("logo_url")]
        public String LogoUrl
        {
            get;
            set;
        }

        [JsonProperty("brief")]
        public String Brief
        {
            get;
            set;
        }

        [JsonProperty("category_main")]
        public Nullable<Int64> CategoryMain
        {
            get;
            set;
        }

        [JsonProperty("category_main_name")]
        public String CategoryMainName
        {
            get;
            set;
        }

    }

}
