﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.After;

namespace JdSdk.Request.After
{
﻿    public class AfterStateUpdateRequest : JdRequestBase<AfterStateUpdateResponse>
    {
        public String ReturnId
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.after.state.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("return_id" ,this.ReturnId);
            paramters.Add("trade_no" ,this.TradeNo);
        }

    }

}
