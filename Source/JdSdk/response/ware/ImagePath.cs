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
        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("imageList")]
        public List<Image> ImageList
        {
            get;
            set;
        }

    }

}
