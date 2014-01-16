﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Seller
{
﻿    [Serializable]
    public class VenderBrandPubInfo : JdObject
    {
        [JsonProperty("erpBrandId")]
        public Nullable<Int32> ErpBrandId
        {
            get;
            set;
        }

        [JsonProperty("brandName")]
        public String BrandName
        {
            get;
            set;
        }

    }

}
