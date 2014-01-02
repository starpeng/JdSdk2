﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Imgzone
{
﻿    [Serializable]
    public class ImgzoneZoneInfo : JdObject
    {
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        [JsonProperty("used_size")]
        public Nullable<Int32> UsedSize
        {
            get;
            set;
        }

        [JsonProperty("total_size")]
        public Nullable<Int32> TotalSize
        {
            get;
            set;
        }

        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

    }

}
