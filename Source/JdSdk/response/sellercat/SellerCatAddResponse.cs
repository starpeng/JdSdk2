﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sellercat
{
﻿    [Serializable]
    public class SellerCatAddResponse : JdResponse
    {
        [JsonProperty("create_time")]
        public String CreateTime
        {
            get;
            set;
        }

        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

    }

}
