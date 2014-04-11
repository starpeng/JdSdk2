﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Kuaiche.ZnJosPlanService
{
﻿    [Serializable]
    public class ResultStatus : JdObject
    {
        [JsonProperty("result_code")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("result_message")]
        public String ResultMessage
        {
            get;
            set;
        }

    }

}
