﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class VideoBigFieldEntity : JdObject
    {
        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("firstClassId")]
        public Nullable<Int32> FirstClassId
        {
            get;
            set;
        }

        [JsonProperty("videoBigFieldInfo")]
        public VideoBigFieldInfo VideoBigFieldInfo
        {
            get;
            set;
        }

    }

}
