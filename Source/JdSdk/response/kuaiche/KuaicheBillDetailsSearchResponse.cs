﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheBillDetailsSearchResponse : JdResponse
    {
        [JsonProperty("list")]
        public List<BillDetailVO> List
        {
            get;
            set;
        }

    }

}
