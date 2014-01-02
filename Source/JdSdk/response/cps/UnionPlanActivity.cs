﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class UnionPlanActivity : JdObject
    {
        [JsonProperty("activityName")]
        public String ActivityName
        {
            get;
            set;
        }

        [JsonProperty("activityUrl")]
        public String ActivityUrl
        {
            get;
            set;
        }

        [JsonProperty("activityStarttime")]
        public Nullable<DateTime> ActivityStarttime
        {
            get;
            set;
        }

        [JsonProperty("activityEndtime")]
        public Nullable<DateTime> ActivityEndtime
        {
            get;
            set;
        }

        [JsonProperty("activityImgList")]
        public List<UnionActivityimg> ActivityImgList
        {
            get;
            set;
        }

    }

}
