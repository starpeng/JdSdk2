﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareProductimageGetResponse : JdResponse
    {
        [JsonProperty("image_path_list")]
        public List<ImagePath> ImagePathList
        {
            get;
            set;
        }

    }

}
