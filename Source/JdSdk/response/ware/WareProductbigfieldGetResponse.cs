﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareProductbigfieldGetResponse : JdResponse
    {
        [JsonProperty("shou_hou")]
        public String ShouHou
        {
            get;
            set;
        }

        [JsonProperty("wdis")]
        public String Wdis
        {
            get;
            set;
        }

        [JsonProperty("prop_code")]
        public String PropCode
        {
            get;
            set;
        }

        [JsonProperty("ware_qd")]
        public String WareQd
        {
            get;
            set;
        }

    }

}
