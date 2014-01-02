﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceHistoryGetRequest : JdRequestBase<AfsserviceHistoryGetResponse>
    {
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.history.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("orderId" ,this.OrderId);
        }

    }

}
