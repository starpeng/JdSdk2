﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ProductSkuList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("skuSize")]
        public List<SkuSize> SkuSize
        {
            get;
            set;
        }

        [JsonProperty("skuColor")]
        public List<SkuColor> SkuColor
        {
            get;
            set;
        }

    }

}
