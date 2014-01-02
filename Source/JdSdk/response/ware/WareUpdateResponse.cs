﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareUpdateResponse : JdResponse
    {
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        [JsonProperty("skus")]
        public List<SkuInfo> _SkuInfo
        {
            get;
            set;
        }

﻿        [Serializable]
        public class SkuInfo : JdObject
        {
            [JsonProperty("sku_id")]
            public Nullable<Int64> SkuId
            {
                get;
                set;
            }

            [JsonProperty("attribute")]
            public String Attribute
            {
                get;
                set;
            }

        }

    }

}
