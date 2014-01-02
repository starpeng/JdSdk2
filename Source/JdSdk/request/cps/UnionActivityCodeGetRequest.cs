﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionActivityCodeGetRequest : JdRequestBase<UnionActivityCodeGetResponse>
    {
        public Nullable<Int64> ActivityId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.activity.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("activity_id" ,this.ActivityId);
        }

    }

}
