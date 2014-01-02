﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderGetRequest : JdRequestBase<OrderGetResponse>
    {
        public String OrderId
        {
            get;
            set;
        }

        public String OptionalFields
        {
            get;
            set;
        }

        public String OrderState
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("optional_fields" ,this.OptionalFields);
            paramters.Add("order_state" ,this.OrderState);
        }

    }

}
