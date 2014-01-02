﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class EtmsTraceGetRequest : JdRequestBase<EtmsTraceGetResponse>
    {
        public String WaybillCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.trace.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waybillCode" ,this.WaybillCode);
        }

    }

}
