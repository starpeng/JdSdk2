﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsRefuseRequest : JdRequestBase<DropshipDpsRefuseResponse>
    {
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        public String RefuseReason
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.refuse"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("customOrderId" ,this.CustomOrderId);
            paramters.Add("refuseReason" ,this.RefuseReason);
        }

    }

}
