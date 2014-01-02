﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderResponse : JdObject
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

        [JsonProperty("order_list")]
        public List<OrderinfoResponse> OrderList
        {
            get;
            set;
        }

    }

}
