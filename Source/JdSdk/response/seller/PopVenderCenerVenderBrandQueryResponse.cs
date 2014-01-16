﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class PopVenderCenerVenderBrandQueryResponse : JdResponse
    {
        [JsonProperty("brandList")]
        public List<VenderBrandPubInfo> BrandList
        {
            get;
            set;
        }

    }

}
