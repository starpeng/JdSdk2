﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Photo;

namespace JdSdk.Request.Photo
{
﻿    [Serializable]
    public class PhotoProxyResult : JdObject
    {
        [JsonProperty("picture_url")]
        public String PictureUrl
        {
            get;
            set;
        }

    }

}
