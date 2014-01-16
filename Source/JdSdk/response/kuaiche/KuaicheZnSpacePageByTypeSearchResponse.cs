﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class KuaicheZnSpacePageByTypeSearchResponse : JdResponse
    {
        [JsonProperty("space_page_info_list")]
        public List<SpacePageInfo> SpacePageInfoList
        {
            get;
            set;
        }

    }

}
