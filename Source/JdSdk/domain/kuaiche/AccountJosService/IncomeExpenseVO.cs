﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Kuaiche.AccountJosService
{
﻿    [Serializable]
    public class IncomeExpenseVO : JdObject
    {
        [JsonProperty("swift_number")]
        public Nullable<Int64> SwiftNumber
        {
            get;
            set;
        }

        [JsonProperty("creat_time")]
        public String CreatTime
        {
            get;
            set;
        }

        [JsonProperty("amount")]
        public Nullable<Int64> Amount
        {
            get;
            set;
        }

        [JsonProperty("in_out_type")]
        public Nullable<Int64> InOutType
        {
            get;
            set;
        }

        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        [JsonProperty("show_date")]
        public String ShowDate
        {
            get;
            set;
        }

    }

}
