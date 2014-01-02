﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class BillVO : JdObject
    {
        [JsonProperty("bill_no")]
        public Nullable<Int64> BillNo
        {
            get;
            set;
        }

        [JsonProperty("bill_month")]
        public String BillMonth
        {
            get;
            set;
        }

        [JsonProperty("cost")]
        public String Cost
        {
            get;
            set;
        }

    }

}
