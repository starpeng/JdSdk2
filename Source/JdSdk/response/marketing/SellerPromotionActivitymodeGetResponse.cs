﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class SellerPromotionActivitymodeGetResponse : JdResponse
    {
        [JsonProperty("activity_mode")]
        public ActivityModeVO ActivityMode
        {
            get;
            set;
        }

    }

}
