﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.After
{
﻿    [Serializable]
    public class AfterStateUpdateResponse : JdResponse
    {
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        [JsonProperty("return_id")]
        public String ReturnId
        {
            get;
            set;
        }

    }

}
