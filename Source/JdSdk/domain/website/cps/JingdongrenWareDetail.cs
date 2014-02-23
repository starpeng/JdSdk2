﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Cps
{
﻿    [Serializable]
    public class JingdongrenWareDetail : JdObject
    {
        [JsonProperty("ware")]
         public Ware.Ware Ware
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
