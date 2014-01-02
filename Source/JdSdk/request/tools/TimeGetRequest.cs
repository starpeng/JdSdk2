﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Tools;

namespace JdSdk.Request.Tools
{
﻿    public class TimeGetRequest : JdRequestBase<TimeGetResponse>
    {
        public override String ApiName
        {
            get{ return "360buy.time.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
