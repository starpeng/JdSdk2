﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderinfoStatusFlowResponse : JdObject
    {
        [JsonProperty("state_value")]
        public Nullable<Byte> StateValue
        {
            get;
            set;
        }

        [JsonProperty("state_time")]
        public String StateTime
        {
            get;
            set;
        }

        [JsonProperty("state_operator")]
        public String StateOperator
        {
            get;
            set;
        }

        [JsonProperty("state_remark")]
        public String StateRemark
        {
            get;
            set;
        }

    }

}
