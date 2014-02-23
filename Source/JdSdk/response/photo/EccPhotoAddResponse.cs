﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Photo
{
﻿    [Serializable]
    public class EccPhotoAddResponse : JdResponse
    {
        [JsonProperty("photo_proxy_result")]
         public JdSdk.Request.Photo.PhotoProxyResult PhotoProxyResult
        {
            get;
            set;
        }

    }

}
