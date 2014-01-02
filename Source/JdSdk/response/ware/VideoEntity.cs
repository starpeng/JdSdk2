﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class VideoEntity : JdObject
    {
        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("videoInfo")]
        public VideoInfo VideoInfo
        {
            get;
            set;
        }

    }

}
