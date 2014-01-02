﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class MaterialLableJO : JdObject
    {
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        [JsonProperty("label_name")]
        public String LabelName
        {
            get;
            set;
        }

        [JsonProperty("buyout_price")]
        public Nullable<Decimal> BuyoutPrice
        {
            get;
            set;
        }

        [JsonProperty("cpc_price")]
        public Nullable<Decimal> CpcPrice
        {
            get;
            set;
        }

    }

}
