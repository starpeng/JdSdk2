﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class WareStrollSpecialListGetResponse : JdResponse
    {
        [JsonProperty("specialPriceWareList")]
        public SpecialPriceWareList SpecialPriceWareList
        {
            get;
            set;
        }

    }

}
