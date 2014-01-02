﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class LogisticsO2oOrderCarriageRequest : JdRequestBase<LogisticsO2oOrderCarriageResponse>
    {
        public String Pin
        {
            get;
            set;
        }

        public String OrderId
        {
            get;
            set;
        }

        public String CarrierNo
        {
            get;
            set;
        }

        public String DeliverNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.o2o.order.carriage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pin" ,this.Pin);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("carrier_no" ,this.CarrierNo);
            paramters.Add("deliver_no" ,this.DeliverNo);
        }

    }

}
