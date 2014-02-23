﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class CmsActivity : JdObject
    {
        [JsonProperty("activityId")]
        public Nullable<Int32> ActivityId
        {
            get;
            set;
        }

        [JsonProperty("catelogyId")]
        public Nullable<Int32> CatelogyId
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

        [JsonProperty("endDate")]
        public String EndDate
        {
            get;
            set;
        }

        [JsonProperty("imageUrl")]
        public String ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("startDate")]
        public String StartDate
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public String Status
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

    }

}
