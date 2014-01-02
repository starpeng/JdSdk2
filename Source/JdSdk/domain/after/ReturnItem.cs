﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.After
{
﻿    [Serializable]
    public class ReturnItem : JdObject
    {
        [JsonProperty("return_item_id")]
        public String ReturnItemId
        {
            get;
            set;
        }

        [JsonProperty("attachment_code")]
        public String AttachmentCode
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        [JsonProperty("sku_name")]
        public String SkuName
        {
            get;
            set;
        }

        [JsonProperty("order_id")]
        public String OrderId
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

        [JsonProperty("return_type")]
        public String ReturnType
        {
            get;
            set;
        }

        [JsonProperty("return_reason")]
        public String ReturnReason
        {
            get;
            set;
        }

        [JsonProperty("modifid_time")]
        public String ModifidTime
        {
            get;
            set;
        }

    }

}
