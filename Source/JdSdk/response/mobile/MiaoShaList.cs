﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Mobile
{
﻿    [Serializable]
    public class MiaoShaList : JdObject
    {
        [JsonProperty("startRemainTime")]
        public Nullable<Int64> StartRemainTime
        {
            get;
            set;
        }

        [JsonProperty("endRemainTime")]
        public Nullable<Int64> EndRemainTime
        {
            get;
            set;
        }

        [JsonProperty("wareInfoList")]
        public List<WareInfo> WareInfoList
        {
            get;
            set;
        }

    }

}
