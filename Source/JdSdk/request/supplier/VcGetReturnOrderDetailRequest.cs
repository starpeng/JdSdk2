﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class VcGetReturnOrderDetailRequest : JdRequestBase<VcGetReturnOrderDetailResponse>
    {
        public Nullable<Int64> ReturnId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.vc.get.return.order.detail"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("returnId" ,this.ReturnId);
        }

    }

}
