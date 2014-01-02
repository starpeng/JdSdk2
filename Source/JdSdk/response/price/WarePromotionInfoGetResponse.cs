﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class WarePromotionInfoGetResponse : JdResponse
    {
        [JsonProperty("promoInfoResponse")]
        public AdwordResponse PromoInfoResponse
        {
            get;
            set;
        }

    }

}
