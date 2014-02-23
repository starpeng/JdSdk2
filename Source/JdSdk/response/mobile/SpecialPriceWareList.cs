﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class SpecialPriceWareList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("wareInfoList")]
        public List<WareInfo> WareInfoList
        {
            get;
            set;
        }

        [JsonProperty("specialPriceWare")]
        public List<WareInfo> SpecialPriceWare
        {
            get;
            set;
        }

    }

}
