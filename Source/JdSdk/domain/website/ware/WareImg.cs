﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Ware
{
﻿    [Serializable]
    public class WareImg : JdObject
    {
        [JsonProperty("img_name")]
        public String ImgName
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public String Url
        {
            get;
            set;
        }

    }

}
