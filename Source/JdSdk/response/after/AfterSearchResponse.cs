﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.After;

namespace JdSdk.Response.After
{
﻿    [Serializable]
    public class AfterSearchResponse : JdResponse
    {
        [JsonProperty("after")]
        public ReturnGoods ReturnGoods
        {
            get;
            set;
        }

    }

}
