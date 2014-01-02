﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Innertest
{
﻿    [Serializable]
    public class AreaCityGetResponse : JdResponse
    {
        [JsonProperty("city_areas")]
        public AreaListBeanVO[] CityAreas
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
