﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Supplier.ReturnOrderJosAPI;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class VcReturnOrderListPageGetResponse : JdResponse
    {
        [JsonProperty("roResultDto")]
        public RoResultDto RoResultDto
        {
            get;
            set;
        }

    }

}
