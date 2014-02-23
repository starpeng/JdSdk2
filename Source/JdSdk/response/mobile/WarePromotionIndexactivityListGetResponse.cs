﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Mobile.PromotionsOpenService;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WarePromotionIndexactivityListGetResponse : JdResponse
    {
        [JsonProperty("activityInfoList")]
        public ActivityList ActivityInfoList
        {
            get;
            set;
        }

    }

}
