﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderPrintDataWare : JdObject
    {
        [JsonProperty("ware")]
        public String WareId
        {
            get;
            set;
        }

        [JsonProperty("ware_name")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("num")]
        public String Num
        {
            get;
            set;
        }

        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        [JsonProperty("produce_no")]
        public String ProduceNo
        {
            get;
            set;
        }

    }

}
