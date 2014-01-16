﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Im
{
﻿    [Serializable]
    public class ImPopEvaluationlistGetResponse : JdResponse
    {
        [JsonProperty("Evaluation")]
        public List<Evaluation> Evaluation
        {
            get;
            set;
        }

    }

}
