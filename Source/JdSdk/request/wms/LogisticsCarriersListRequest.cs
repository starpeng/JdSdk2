﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsCarriersListRequest : JdRequestBase<LogisticsCarriersListResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.logistics.carriers.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
