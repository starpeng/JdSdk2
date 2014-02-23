﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ImagePath : JdObject
    {
        [JsonProperty("newpath")]
        public String Newpath
        {
            get;
            set;
        }

        [JsonProperty("bigpath")]
        public String Bigpath
        {
            get;
            set;
        }

        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

    }

}
