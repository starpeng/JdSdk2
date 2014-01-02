﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderExportResponse : JdObject
    {
        [JsonProperty("process_code")]
        public Nullable<Int32> ProcessCode
        {
            get;
            set;
        }

        [JsonProperty("process_status")]
        public String ProcessStatus
        {
            get;
            set;
        }

        [JsonProperty("error_message")]
        public String ErrorMessage
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

        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        [JsonProperty("order_update_time")]
        public String OrderUpdateTime
        {
            get;
            set;
        }

    }

}
