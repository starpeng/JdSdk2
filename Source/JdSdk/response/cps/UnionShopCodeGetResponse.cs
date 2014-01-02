﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionShopCodeGetResponse : JdResponse
    {
        [JsonProperty("url_code")]
        public String UrlCode
        {
            get;
            set;
        }

        [JsonProperty("img_code")]
        public String ImgCode
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

        [JsonProperty("message")]
        public String Message
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

    }

}
