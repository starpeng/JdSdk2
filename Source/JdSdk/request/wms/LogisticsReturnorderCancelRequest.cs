﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsReturnorderCancelRequest : JdRequestBase<LogisticsReturnorderCancelResponse>
    {
        public String ReceiptNo
        {
            get;
            set;
        }

        public String IsvSource
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.returnorder.cancel"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("receipt_no" ,this.ReceiptNo);
            paramters.Add("isv_source" ,this.IsvSource);
        }

    }

}
