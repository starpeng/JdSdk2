﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Cps
{
﻿    [Serializable]
    public class PromotionActivityVO : JdObject
    {
        [JsonProperty("activity_list")]
        public List<JosActivityImgVO> ActivityList
        {
            get;
            set;
        }

        [JsonProperty("total_count")]
        public Nullable<Int32> TotalCount
        {
            get;
            set;
        }

    }

}
