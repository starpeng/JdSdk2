﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class PromoPropVO : JdObject
    {
        [JsonProperty("promo_id")]
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        [JsonProperty("num")]
        public Nullable<Int32> Num
        {
            get;
            set;
        }

        [JsonProperty("used_way")]
        public Nullable<Int32> UsedWay
        {
            get;
            set;
        }

    }

}
