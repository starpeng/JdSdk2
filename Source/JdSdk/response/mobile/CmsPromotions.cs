﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CmsPromotions : JdObject
    {
        [JsonProperty("catelogyId")]
        public Nullable<Int32> CatelogyId
        {
            get;
            set;
        }

        [JsonProperty("imageUrl")]
        public String ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("promitionInfo")]
        public String PromitionInfo
        {
            get;
            set;
        }

        [JsonProperty("promotionId")]
        public String PromotionId
        {
            get;
            set;
        }

        [JsonProperty("promotionName")]
        public String PromotionName
        {
            get;
            set;
        }

    }

}
