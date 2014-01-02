﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Vender
{
﻿    [Serializable]
    public class Vender : JdObject
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

        [JsonProperty("sub_account")]
        public Nullable<Int32> SubAccount
        {
            get;
            set;
        }

        [JsonProperty("access_code")]
        public String AccessCode
        {
            get;
            set;
        }

        [JsonProperty("category_main")]
        public Nullable<Int32> CategoryMain
        {
            get;
            set;
        }

        [JsonProperty("login_name")]
        public String LoginName
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

        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

    }

}
