﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class WarePriceGetResponse : JdResponse
    {
        [JsonProperty("price_changes")]
        public List<PriceChange> PriceChanges
        {
            get;
            set;
        }

    }

}
