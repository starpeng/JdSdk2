﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class LogisticsOtherOutstoreQueryResponse : JdResponse
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

        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        [JsonProperty("isv_outbound_no")]
        public String IsvOutboundNo
        {
            get;
            set;
        }

        [JsonProperty("josl_status")]
        public String JoslStatus
        {
            get;
            set;
        }

        [JsonProperty("complete_time")]
        public Nullable<DateTime> CompleteTime
        {
            get;
            set;
        }

        [JsonProperty("order_details")]
        public List<ResponseOrderOtherDetail> OrderDetails
        {
            get;
            set;
        }

        [JsonProperty("carriers_id")]
        public String CarriersId
        {
            get;
            set;
        }

        [JsonProperty("carriers_name")]
        public String CarriersName
        {
            get;
            set;
        }

        [JsonProperty("delivery_no_list")]
        public List<String> DeliveryNoList
        {
            get;
            set;
        }

    }

}
