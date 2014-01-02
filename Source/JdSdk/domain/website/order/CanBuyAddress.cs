﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Order
{
﻿    [Serializable]
    public class CanBuyAddress : JdObject
    {
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("is_sup_cod")]
        public String IsSupCOD
        {
            get;
            set;
        }

    }

}
