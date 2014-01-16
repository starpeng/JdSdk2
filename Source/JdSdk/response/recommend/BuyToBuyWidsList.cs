﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Recommend
{
﻿    [Serializable]
    public class BuyToBuyWidsList : JdObject
    {
        [JsonProperty("resultCode")]
        public Nullable<Int32> ResultCode
        {
            get;
            set;
        }

        [JsonProperty("buyToBuyWids")]
        public List<CmsActivityWare> BuyToBuyWids
        {
            get;
            set;
        }

    }

}
