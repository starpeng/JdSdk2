﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.O2O.StoreOFCService
{
﻿    [Serializable]
    public class OrderServiceResponse : JdObject
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

    }

}
