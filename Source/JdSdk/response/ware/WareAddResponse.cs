﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareAddResponse : JdResponse
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("skus")]
        public List<JdSdk.Domain.Ware.Sku> SkuInfo
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

    }

 }
