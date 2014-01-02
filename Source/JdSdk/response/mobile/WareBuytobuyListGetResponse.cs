﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WareBuytobuyListGetResponse : JdResponse
    {
        [JsonProperty("buyToBuyWidsList")]
        public BuyToBuyWidsList BuyToBuyWidsList
        {
            get;
            set;
        }

    }

}
