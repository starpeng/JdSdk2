﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Category
{
﻿    [Serializable]
    public class ShopCategoryInfo : JdObject
    {
        [JsonProperty("shop_id")]
        public String ShopId
        {
            get;
            set;
        }

        [JsonProperty("parent_id")]
        public String ParentId
        {
            get;
            set;
        }

        [JsonProperty("order_no")]
        public String OrderNo
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

        [JsonProperty("home_show")]
        public String HomeShow
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

    }

}
