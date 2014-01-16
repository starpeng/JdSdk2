﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Sku;

namespace JdSdk.Request.Sku
{
﻿    public class OrderVenderRemarkQueryByOrderIdRequest : JdRequestBase<OrderVenderRemarkQueryByOrderIdResponse>
    {
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.venderRemark.queryByOrderId"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
        }

    }

}
