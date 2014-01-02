﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderSoplOutstorageRequest : JdRequestBase<OrderSoplOutstorageResponse>
    {
        public String OrderId
        {
            get;
            set;
        }

        public String PackageNum
        {
            get;
            set;
        }

        public String SendType
        {
            get;
            set;
        }

        public String AddressId
        {
            get;
            set;
        }

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

        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.sopl.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("package_num" ,this.PackageNum);
            paramters.Add("send_type" ,this.SendType);
            paramters.Add("address_id" ,this.AddressId);
            paramters.Add("logistics_id" ,this.LogisticsId);
            paramters.Add("waybill" ,this.Waybill);
            paramters.Add("trade_no" ,this.TradeNo);
        }

    }

}
