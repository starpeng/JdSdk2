﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class Guang : JdObject
    {
        [JsonProperty("foldFlag")]
        public String FoldFlag
        {
            get;
            set;
        }

        [JsonProperty("functionId")]
        public String FunctionId
        {
            get;
            set;
        }

        [JsonProperty("icon")]
        public String Icon
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public String Type
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
