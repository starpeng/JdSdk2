﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class VenderInfoResult : JdObject
    {
        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

        [JsonProperty("col_type")]
        public Nullable<Int32> ColType
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

        [JsonProperty("cate_main")]
        public Nullable<Int64> CateMain
        {
            get;
            set;
        }

    }

}
