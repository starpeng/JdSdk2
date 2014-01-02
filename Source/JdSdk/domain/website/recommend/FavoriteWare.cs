﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Recommend
{
﻿    [Serializable]
    public class FavoriteWare : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String WareName
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        [JsonProperty("ad_word")]
        public String AdWord
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

    }

}
