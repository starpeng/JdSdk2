﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionActivityimg : JdObject
    {
        [JsonProperty("imgUrl")]
        public String ImgUrl
        {
            get;
            set;
        }

    }

}
