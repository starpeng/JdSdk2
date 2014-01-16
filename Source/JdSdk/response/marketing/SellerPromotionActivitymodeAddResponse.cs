﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class SellerPromotionActivitymodeAddResponse : JdResponse
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

    }

}
