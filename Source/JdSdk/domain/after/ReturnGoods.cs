﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain.After
{
﻿    [Serializable]
    public class ReturnGoods : JdObject
    {
        [JsonProperty("total_num")]
        public Nullable<Int32> TotalNum
        {
            get;
            set;
        }

        [JsonProperty("return_infos")]
        public List<ReturnInfo> ReturnInfos
        {
            get;
            set;
        }

    }

}
