﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Wms
{
﻿    [Serializable]
    public class HashMap : JdObject
    {
        [JsonProperty("order_list")]
        public List<ResponseOrderStatus> OrderList
        {
            get;
            set;
        }

    }

}
