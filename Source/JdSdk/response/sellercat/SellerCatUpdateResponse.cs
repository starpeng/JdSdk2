﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sellercat
{
﻿    [Serializable]
    public class SellerCatUpdateResponse : JdResponse
    {
        [JsonProperty("modified")]
        public String Modified
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
