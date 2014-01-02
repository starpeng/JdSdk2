﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderSopOutstorageRequest : JdRequestBase<OrderSopOutstorageResponse>
    {
        public String LogisticsId
        {
            get;
            set;
        }

        public String Waybill
        {
            get;
            set;
        }

        public String OrderId
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
            get{ return "360buy.order.sop.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("logistics_id" ,this.LogisticsId);
            paramters.Add("waybill" ,this.Waybill);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("trade_no" ,this.TradeNo);
        }

    }

}
