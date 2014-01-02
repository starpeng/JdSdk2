﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPlanlistSearchRequest : JdRequestBase<UnionPlanlistSearchResponse>
    {
        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.planlist.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pageIndex" ,this.PageIndex);
            paramters.Add("pageSize" ,this.PageSize);
        }

    }

}
