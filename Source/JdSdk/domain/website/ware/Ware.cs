﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Ware
{
﻿    [Serializable]
    public class Ware : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String JdPrice
        {
            get;
            set;
        }

        [JsonProperty("m_url")]
        public String MUrl
        {
            get;
            set;
        }

        [JsonProperty("ware_imgs")]
        public List<WareImg> WareImgs
        {
            get;
            set;
        }

        [JsonProperty("skus")]
        public List<Sku> Skus
        {
            get;
            set;
        }

    }

}
