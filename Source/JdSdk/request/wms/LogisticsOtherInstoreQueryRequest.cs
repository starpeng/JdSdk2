﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOtherInstoreQueryRequest : JdRequestBase<LogisticsOtherInstoreQueryResponse>
    {
        public String InBoundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.otherInstore.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("in_bound_no" ,this.InBoundNo);
        }

    }

}
