﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Cps
{
﻿    [Serializable]
    public class JingdongrenWare : JdObject
    {
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        [JsonProperty("pic_url")]
        public String PicUrl
        {
            get;
            set;
        }

        [JsonProperty("commission_fee")]
        public String CommissionFee
        {
            get;
            set;
        }

        [JsonProperty("click_url")]
        public String ClickUrl
        {
            get;
            set;
        }

        [JsonProperty("shop_click_url")]
        public String ShopClickUrl
        {
            get;
            set;
        }

    }

}
