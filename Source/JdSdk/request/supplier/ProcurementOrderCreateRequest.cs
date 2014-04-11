﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class ProcurementOrderCreateRequest : JdRequestBase<ProcurementOrderCreateResponse>
    {
        public Nullable<Int32> DeliverCenterId
        {
            get;
            set;
        }

        public String PurchaserErpCode
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }

        public String WareId
        {
            get;
            set;
        }

        public String AllocationDeliverCenterId
        {
            get;
            set;
        }

        public String OriginalNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.procurement.order.create"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("deliverCenterId" ,this.DeliverCenterId);
            paramters.Add("purchaserErpCode" ,this.PurchaserErpCode);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("wareId" ,this.WareId);
            paramters.Add("allocationDeliverCenterId" ,this.AllocationDeliverCenterId);
            paramters.Add("originalNum" ,this.OriginalNum);
        }

    }

}
