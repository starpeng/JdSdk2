﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class ResultVO : JdObject
    {
        [JsonProperty("successed")]
        public Nullable<Boolean> Successed
        {
            get;
            set;
        }

        [JsonProperty("code")]
        public Nullable<Int32> Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        [JsonProperty("result")]
        public PlanInfoVO Result
        {
            get;
            set;
        }

    }

}
