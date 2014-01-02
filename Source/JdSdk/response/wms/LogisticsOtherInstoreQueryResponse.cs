﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsOtherInstoreQueryResponse : JdResponse
    {
        [JsonProperty("process_code")]
        public Nullable<Int64> ProcessCode
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

        [JsonProperty("inbound_no")]
        public String InboundNo
        {
            get;
            set;
        }

        [JsonProperty("po_no")]
        public String PoNo
        {
            get;
            set;
        }

        [JsonProperty("inbound_status")]
        public String InboundStatus
        {
            get;
            set;
        }

        [JsonProperty("status_update_time")]
        public Nullable<DateTime> StatusUpdateTime
        {
            get;
            set;
        }

        [JsonProperty("task_details")]
        public List<OtherInstoreOrderDetail> TaskDetails
        {
            get;
            set;
        }

    }

}
