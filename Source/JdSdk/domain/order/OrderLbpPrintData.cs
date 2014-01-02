﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderLbpPrintData : JdObject
    {
        [JsonProperty("pickUpSign")]
        public String PickUpSign
        {
            get;
            set;
        }

        [JsonProperty("pickUpSign_type")]
        public Nullable<Int32> PickUpSignType
        {
            get;
            set;
        }

        [JsonProperty("orderLevelSign")]
        public String OrderLevelSign
        {
            get;
            set;
        }

        [JsonProperty("orderLevel_Type")]
        public Nullable<Int32> OrderLevelType
        {
            get;
            set;
        }

    }

}
