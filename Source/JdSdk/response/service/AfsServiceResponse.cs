﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsServiceResponse : JdObject
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

        [JsonProperty("total_page")]
        public Nullable<Int32> TotalPage
        {
            get;
            set;
        }

        [JsonProperty("cur_page_num")]
        public Nullable<Int32> CurPageNum
        {
            get;
            set;
        }

        [JsonProperty("customer_order_list")]
        public List<AfsServiceDto> CustomerOrderList
        {
            get;
            set;
        }

    }

}
