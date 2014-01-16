﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Marketing
{
﻿    [Serializable]
    public class SellerPromotionCommitResponse : JdResponse
    {
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

    }

}
