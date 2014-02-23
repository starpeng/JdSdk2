﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Ware;

namespace JdSdk.Response.Ware
{
﻿    [Serializable]
    public class WareDelistingGetResponse : JdResponse
    {
        [JsonProperty("ware_infos")]
        public List<Domain.Ware.Ware> WareInfos
        {
            get;
            set;
        }

        [JsonProperty("total")]
        public Nullable<Int32> Total
        {
            get;
            set;
        }

    }

 }
