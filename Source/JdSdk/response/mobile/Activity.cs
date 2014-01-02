﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class Activity : JdObject
    {
        [JsonProperty("activityId")]
        public Nullable<Int32> ActivityId
        {
            get;
            set;
        }

        [JsonProperty("horizontalImag")]
        public String HorizontalImag
        {
            get;
            set;
        }

        [JsonProperty("sortNo")]
        public String SortNo
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

    }

}
