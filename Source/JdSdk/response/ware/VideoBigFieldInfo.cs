﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class VideoBigFieldInfo : JdObject
    {
        [JsonProperty("comments")]
        public String Comments
        {
            get;
            set;
        }

        [JsonProperty("image")]
        public String Image
        {
            get;
            set;
        }

        [JsonProperty("contentDesc")]
        public String ContentDesc
        {
            get;
            set;
        }

        [JsonProperty("editerDesc")]
        public String EditerDesc
        {
            get;
            set;
        }

        [JsonProperty("catalogue")]
        public String Catalogue
        {
            get;
            set;
        }

        [JsonProperty("box_Contents")]
        public String BoxContents
        {
            get;
            set;
        }

        [JsonProperty("material_Description")]
        public String MaterialDescription
        {
            get;
            set;
        }

        [JsonProperty("manual")]
        public String Manual
        {
            get;
            set;
        }

    }

}
