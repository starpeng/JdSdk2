﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Innertest
{
﻿    [Serializable]
    public class AreaTownGetResponse : JdResponse
    {
        [JsonProperty("town_areas")]
        public AreaListBeanVO[] TownAreas
        {
            get;
            set;
        }

        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

    }

}
