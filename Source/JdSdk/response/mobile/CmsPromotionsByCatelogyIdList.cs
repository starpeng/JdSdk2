﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CmsPromotionsByCatelogyIdList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("cmsPromotionsList")]
        public List<CmsPromotions> CmsPromotionsList
        {
            get;
            set;
        }

    }

}
