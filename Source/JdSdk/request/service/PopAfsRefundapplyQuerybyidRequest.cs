﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class PopAfsRefundapplyQuerybyidRequest : JdRequestBase<PopAfsRefundapplyQuerybyidResponse>
    {
        public Nullable<Int64> RaId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.pop.afs.refundapply.querybyid"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ra_id" ,this.RaId);
        }

    }

}
