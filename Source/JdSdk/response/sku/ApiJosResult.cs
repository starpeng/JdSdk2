﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Sku
{
﻿    [Serializable]
    public class ApiJosResult : JdObject
    {
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        [JsonProperty("result_code")]
        public String ResultCode
        {
            get;
            set;
        }

        [JsonProperty("result_describe")]
        public String ResultDescribe
        {
            get;
            set;
        }

    }

}
