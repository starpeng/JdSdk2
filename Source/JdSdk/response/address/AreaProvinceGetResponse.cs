﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Address
{
﻿    [Serializable]
    public class AreaProvinceGetResponse : JdResponse
    {
        [JsonProperty("province_areas")]
        public AreaListBeanVO[] ProvinceAreas
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
