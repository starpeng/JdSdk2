﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsReturnorderQueryRequest : JdRequestBase<LogisticsReturnorderQueryResponse>
    {
        public String ReceiptNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.returnorder.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("receipt_no" ,this.ReceiptNo);
        }

    }

}
