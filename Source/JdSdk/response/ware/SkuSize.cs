﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class SkuSize : JdObject
    {
        [JsonProperty("secKill")]
        public Nullable<Boolean> SecKill
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        [JsonProperty("promotion")]
        public Nullable<Boolean> Promotion
        {
            get;
            set;
        }

        [JsonProperty("directShow")]
        public Nullable<Boolean> DirectShow
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

        [JsonProperty("showMartPrice")]
        public Nullable<Boolean> ShowMartPrice
        {
            get;
            set;
        }

        [JsonProperty("skuId")]
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

    }

}
