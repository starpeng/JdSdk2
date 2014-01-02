﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery
{
﻿    [Serializable]
    public class LogisticsCompanies : JdObject
    {
        [JsonProperty("logistics_list")]
        public List<LogisticsCompany> LogisticsList
        {
            get;
            set;
        }

        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

    }

}
