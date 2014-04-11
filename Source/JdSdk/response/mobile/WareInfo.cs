﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WareInfo : JdObject
    {
        [JsonProperty("adWord")]
        public String AdWord
        {
            get;
            set;
        }

        [JsonProperty("isBook")]
        public Nullable<Boolean> IsBook
        {
            get;
            set;
        }

        [JsonProperty("canFreeRead")]
        public Nullable<Boolean> CanFreeRead
        {
            get;
            set;
        }

        [JsonProperty("endRemainTime")]
        public String EndRemainTime
        {
            get;
            set;
        }

        [JsonProperty("imageUrl")]
        public String ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("jdPrice")]
        public Nullable<Double> JdPrice
        {
            get;
            set;
        }

        [JsonProperty("martPrice")]
        public Nullable<Double> MartPrice
        {
            get;
            set;
        }

        [JsonProperty("startRemainTime")]
        public String StartRemainTime
        {
            get;
            set;
        }

        [JsonProperty("skuId")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

    }

}
