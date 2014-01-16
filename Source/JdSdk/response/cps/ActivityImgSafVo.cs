﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class ActivityImgSafVo : JdObject
    {
        [JsonProperty("img_width")]
        public Nullable<Int32> ImgWidth
        {
            get;
            set;
        }

        [JsonProperty("img_heigth")]
        public Nullable<Int32> ImgHeigth
        {
            get;
            set;
        }

        [JsonProperty("img_url")]
        public String ImgUrl
        {
            get;
            set;
        }

    }

}
