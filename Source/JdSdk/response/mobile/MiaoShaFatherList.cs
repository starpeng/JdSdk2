﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class MiaoShaFatherList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public String Url
        {
            get;
            set;
        }

        [JsonProperty("miaoShaList")]
        public List<MiaoShaList> MiaoShaList
        {
            get;
            set;
        }

    }

}
