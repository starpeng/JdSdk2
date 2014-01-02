﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class SellerVenderInfoGetResponse : JdResponse
    {
        [JsonProperty("vender_info_result")]
        public VenderInfoResult VenderInfoResult
        {
            get;
            set;
        }

    }

}
