﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Workorder
{
﻿    [Serializable]
    public class WosSubbiztypelistGetResponse : JdResponse
    {
        [JsonProperty("safBiztypeDtos")]
        public List<SafBiztypeDTO> SafBiztypeDtos
        {
            get;
            set;
        }

    }

}
