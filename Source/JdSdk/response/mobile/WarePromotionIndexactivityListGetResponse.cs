﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WarePromotionIndexactivityListGetResponse : JdResponse
    {
        [JsonProperty("activityList")]
        public ActivityList ActivityList
        {
            get;
            set;
        }

    }

}
