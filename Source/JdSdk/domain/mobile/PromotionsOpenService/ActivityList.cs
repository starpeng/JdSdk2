﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Mobile.PromotionsOpenService
{
﻿    [Serializable]
    public class ActivityList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("activity")]
        public List<Activit> Activity
        {
            get;
            set;
        }

    }

}
