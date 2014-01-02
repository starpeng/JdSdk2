﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Price
{
﻿    [Serializable]
    public class AdwordGiftSku : JdObject
    {
        [JsonProperty("skuId")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("imagePath")]
        public String ImagePath
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("number")]
        public Nullable<Int32> Number
        {
            get;
            set;
        }

        [JsonProperty("giftType")]
        public Nullable<Int32> GiftType
        {
            get;
            set;
        }

        [JsonProperty("giftState")]
        public Nullable<Int32> GiftState
        {
            get;
            set;
        }

    }

}
