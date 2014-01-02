﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsDeliveryRequest : JdRequestBase<DropshipDpsDeliveryResponse>
    {
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        public Nullable<Int32> CarrierId
        {
            get;
            set;
        }

        public String CarrierBusinessName
        {
            get;
            set;
        }

        public String ShipNo
        {
            get;
            set;
        }

        public Nullable<DateTime> EstimateDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.delivery"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("customOrderId" ,this.CustomOrderId);
            paramters.Add("carrierId" ,this.CarrierId);
            paramters.Add("carrierBusinessName" ,this.CarrierBusinessName);
            paramters.Add("shipNo" ,this.ShipNo);
            paramters.Add("estimateDate" ,this.EstimateDate);
        }

    }

}
