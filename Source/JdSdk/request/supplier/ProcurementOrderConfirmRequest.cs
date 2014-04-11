﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class ProcurementOrderConfirmRequest : JdRequestBase<ProcurementOrderConfirmResponse>
    {
        public Nullable<Int64> OrderId
        {
            get;
            set;
        }

        public Nullable<DateTime> DeliveryTime
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String DeliverCenterId
        {
            get;
            set;
        }

        public String BackExplanationType
        {
            get;
            set;
        }

        public String ConfirmNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.procurement.order.confirm"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("orderId" ,this.OrderId);
            paramters.Add("deliveryTime" ,this.DeliveryTime);
            paramters.Add("wareId" ,this.WareId);
            paramters.Add("deliverCenterId" ,this.DeliverCenterId);
            paramters.Add("backExplanationType" ,this.BackExplanationType);
            paramters.Add("confirmNum" ,this.ConfirmNum);
        }

    }

}
