﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsPoGetRequest : JdRequestBase<LogisticsPoGetResponse>
    {
        public String InboundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.po.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("inbound_no" ,this.InboundNo);
        }

    }

}
