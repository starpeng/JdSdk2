﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class ResponseStock : JdObject
    {
        [JsonProperty("process_code")]
        public String ProcessCode
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

        [JsonProperty("stock_details")]
        public List<StockDetail> StockDetails
        {
            get;
            set;
        }

    }

}
