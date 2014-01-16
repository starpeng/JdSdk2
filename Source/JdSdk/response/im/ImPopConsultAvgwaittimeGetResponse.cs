﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopConsultAvgwaittimeGetResponse : JdResponse
    {
        [JsonProperty("avgTime")]
        public Nullable<Double> AvgTime
        {
            get;
            set;
        }

    }

}
