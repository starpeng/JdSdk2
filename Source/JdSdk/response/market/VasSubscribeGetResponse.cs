﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Market
{
﻿    [Serializable]
    public class VasSubscribeGetResponse : JdResponse
    {
        [JsonProperty("item_code")]
        public String ItemCode
        {
            get;
            set;
        }

        [JsonProperty("end_date")]
        public String EndDate
        {
            get;
            set;
        }

    }

}
