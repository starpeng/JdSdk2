﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnKeywordgroupListSearchResponse : JdResponse
    {
        [JsonProperty("keyword_group_list")]
        public List<KeywordGroup> KeywordGroupList
        {
            get;
            set;
        }

    }

}
