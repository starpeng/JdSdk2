﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareBasevideoGetResponse : JdResponse
    {
        [JsonProperty("videoEntitys")]
        public List<VideoEntity> VideoEntitys
        {
            get;
            set;
        }

    }

}
