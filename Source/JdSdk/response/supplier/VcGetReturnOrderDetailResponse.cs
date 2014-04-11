﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Supplier.ReturnOrderJosAPI;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class VcGetReturnOrderDetailResponse : JdResponse
    {
        [JsonProperty("detailResultDto")]
        public DetailResultDto DetailResultDto
        {
            get;
            set;
        }

    }

}
