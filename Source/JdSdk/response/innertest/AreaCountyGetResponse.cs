﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Innertest
{
﻿    [Serializable]
    public class AreaCountyGetResponse : JdResponse
    {
        [JsonProperty("county_areas")]
        public AreaListBeanVO[] CountyAreas
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
