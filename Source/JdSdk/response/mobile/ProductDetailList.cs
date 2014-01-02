﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
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

        [JsonProperty("imagePaths")]
        public List<ImagePath> ImagePaths
        {
            get;
            set;
        }

    }

}
