﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Kuaiche
{
﻿    [Serializable]
    public class MaterialLabelVO : JdObject
    {
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        [JsonProperty("label_buyoutPrice")]
        public Nullable<Decimal> LabelBuyoutPrice
        {
            get;
            set;
        }

        [JsonProperty("label_cpcPrice")]
        public Nullable<Decimal> LabelCpcPrice
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

    }

}
