﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Delivery
{
﻿    [Serializable]
    public class LogisticsCompany : JdObject
    {
        [JsonProperty("logistics_id")]
        public Nullable<Int64> LogisticsId
        {
            get;
            set;
        }

        [JsonProperty("logistics_name")]
        public String LogisticsName
        {
            get;
            set;
        }

        [JsonProperty("logistics_remark")]
        public String LogisticsRemark
        {
            get;
            set;
        }

        [JsonProperty("sequence")]
        public String Sequence
        {
            get;
            set;
        }

        [JsonProperty("agree_flag")]
        public String AgreeFlag
        {
            get;
            set;
        }

        [JsonProperty("iscod")]
        public Nullable<Boolean> IsCod
        {
            get;
            set;
        }

    }

}
