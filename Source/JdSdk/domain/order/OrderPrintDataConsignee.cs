﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Order
{
﻿    [Serializable]
    public class OrderPrintDataConsignee : JdObject
    {
        [JsonProperty("cons_name")]
        public String ConsName
        {
            get;
            set;
        }

        [JsonProperty("cons_address")]
        public String ConsAddress
        {
            get;
            set;
        }

        [JsonProperty("cons_phone")]
        public String ConsPhone
        {
            get;
            set;
        }

        [JsonProperty("cons_handset")]
        public String ConsHandset
        {
            get;
            set;
        }

    }

}
