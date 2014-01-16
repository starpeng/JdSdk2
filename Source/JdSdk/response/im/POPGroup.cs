﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class POPGroup : JdObject
    {
        [JsonProperty("shopName")]
        public String ShopName
        {
            get;
            set;
        }

        [JsonProperty("shopUrl")]
        public String ShopUrl
        {
            get;
            set;
        }

        [JsonProperty("waiterCount")]
        public Nullable<Int32> WaiterCount
        {
            get;
            set;
        }

        [JsonProperty("waiterList")]
        public List<Waiter> WaiterList
        {
            get;
            set;
        }

    }

}
