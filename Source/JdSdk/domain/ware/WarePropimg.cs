﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Ware
{
﻿    [Serializable]
    public class WarePropimg : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("img_id")]
        public Nullable<Int32> ImgId
        {
            get;
            set;
        }

        [JsonProperty("color_id")]
        public String ColorId
        {
            get;
            set;
        }

        [JsonProperty("img_url")]
        public String ImgUrl
        {
            get;
            set;
        }

        [JsonProperty("ismain")]
        public String IsMain
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
