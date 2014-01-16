﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionActivityCodeGetResponse : JdResponse
    {
        [JsonProperty("url_code")]
        public String UrlCode
        {
            get;
            set;
        }

        [JsonProperty("img_codes")]
        public List<ActivityImageCode> ImgCodes
        {
            get;
            set;
        }

        [JsonProperty("link_code")]
        public String LinkCode
        {
            get;
            set;
        }

        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }

}
