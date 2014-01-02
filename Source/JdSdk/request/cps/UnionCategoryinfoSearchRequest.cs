﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionCategoryinfoSearchRequest : JdRequestBase<UnionCategoryinfoSearchResponse>
    {
        public String PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.categoryinfo.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("planId" ,this.PlanId);
        }

    }

}
