﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class WosSubbiztypelistGetResponse : JdResponse
    {
        [JsonProperty("saf_biztype_Dtos")]
        public List<SafBiztypeDTO> SafBiztypeDtos
        {
            get;
            set;
        }

    }

}
