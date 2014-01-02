﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.Website.Cps
{
﻿    [Serializable]
    public class CPSSpreadHomeInfoModule : JdObject
    {
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        [JsonProperty("pic_url")]
        public String PicUrl
        {
            get;
            set;
        }

        [JsonProperty("commission_fee")]
        public String CommissionFee
        {
            get;
            set;
        }

        [JsonProperty("click_url")]
        public String ClickUrl
        {
            get;
            set;
        }

    }

}
