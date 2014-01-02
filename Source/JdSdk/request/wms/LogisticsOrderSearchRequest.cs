﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsOrderSearchRequest : JdRequestBase<LogisticsOrderSearchResponse>
    {
        public String ReceiptNos
        {
            get;
            set;
        }

        public String Status
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.order.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("receipt_nos" ,this.ReceiptNos);
            paramters.Add("status" ,this.Status);
        }

    }

}
