﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderSopPrintDataGetRequest : JdRequestBase<OrderSopPrintDataGetResponse>
    {
        public String OrderId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.sop.print.data.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
        }

    }

}
