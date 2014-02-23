﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class ProductDetailList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("productInfo")]
        public ProductInfo ProductInfo
        {
            get;
            set;
        }

        [JsonProperty("imagePathsList")]
        public List<ImagePath> ImagePathsList
        {
            get;
            set;
        }

    }

}
