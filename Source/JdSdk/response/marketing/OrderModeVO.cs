﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class OrderModeVO : JdObject
    {
        [JsonProperty("promo_id")]
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        [JsonProperty("favor_mode")]
        public Nullable<Int32> FavorMode
        {
            get;
            set;
        }

        [JsonProperty("quota")]
        public Nullable<Decimal> Quota
        {
            get;
            set;
        }

        [JsonProperty("rate")]
        public Nullable<Decimal> Rate
        {
            get;
            set;
        }

        [JsonProperty("plus")]
        public Nullable<Decimal> Plus
        {
            get;
            set;
        }

        [JsonProperty("minus")]
        public Nullable<Decimal> Minus
        {
            get;
            set;
        }

        [JsonProperty("link")]
        public String Link
        {
            get;
            set;
        }

    }

}
