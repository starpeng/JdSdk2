﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class RankReturnJO : JdObject
    {
        [JsonProperty("response")]
        public Nullable<Int32> Response
        {
            get;
            set;
        }

        [JsonProperty("rank")]
        public Single[] Rank
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        [JsonProperty("planDate")]
        public String PlanDate
        {
            get;
            set;
        }

    }

}
