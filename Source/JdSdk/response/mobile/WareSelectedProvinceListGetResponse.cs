﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WareSelectedProvinceListGetResponse : JdResponse
    {
        [JsonProperty("provinceList")]
        public ProvinceList ProvinceList
        {
            get;
            set;
        }

    }

}
