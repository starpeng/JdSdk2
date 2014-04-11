﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnPlanSearchKeywordDeleteRequest : JdRequestBase<KuaicheZnPlanSearchKeywordDeleteResponse>
    {
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        public String KeywordIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.search.keyword.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_id" ,this.PlanId);
            paramters.Add("keyword_ids" ,this.KeywordIds);
        }

    }

}
