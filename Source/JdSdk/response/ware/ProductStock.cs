﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ProductStock : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("flag")]
        public Nullable<Boolean> Flag
        {
            get;
            set;
        }

        [JsonProperty("stockStatus")]
        public String StockStatus
        {
            get;
            set;
        }

    }

}
