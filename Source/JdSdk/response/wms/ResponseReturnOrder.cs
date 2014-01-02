﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class ResponseReturnOrder : JdObject
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

        [JsonProperty("josl_inbound_no")]
        public String JoslInboundNo
        {
            get;
            set;
        }

        [JsonProperty("return_order_no")]
        public String ReturnOrderNo
        {
            get;
            set;
        }

        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        [JsonProperty("complete_time")]
        public String CompleteTime
        {
            get;
            set;
        }

    }

}
