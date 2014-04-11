﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsOutboundRequest : JdRequestBase<DropshipDpsOutboundResponse>
    {
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.outbound"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("customOrderId" ,this.CustomOrderId);
        }

    }

}
