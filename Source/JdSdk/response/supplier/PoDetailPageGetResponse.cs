﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Supplier.PurchaseOrderJosAPI;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class PoDetailPageGetResponse : JdResponse
    {
        [JsonProperty("detailResultDto")]
        public DetailResultDto DetailResultDto
        {
            get;
            set;
        }

    }

}
