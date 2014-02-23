﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderVenderRemarkUpdateRequest : JdRequestBase<OrderVenderRemarkUpdateResponse>
    {
        public String OrderId
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public String Flag
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.vender.remark.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("trade_no" ,this.TradeNo);
            paramters.Add("flag" ,this.Flag);
        }

    }

}
