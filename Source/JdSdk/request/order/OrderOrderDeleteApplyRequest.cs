﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderOrderDeleteApplyRequest : JdRequestBase<OrderOrderDeleteApplyResponse>
    {
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public Nullable<Int32> DelApplyType
        {
            get;
            set;
        }

        public String DelApplyReason
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.orderDelete.apply"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("del_apply_type" ,this.DelApplyType);
            paramters.Add("del_apply_reason" ,this.DelApplyReason);
        }

    }

}
