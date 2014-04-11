﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnPlanSearchKeywordUpdateRequest : JdRequestBase<KuaicheZnPlanSearchKeywordUpdateResponse>
    {
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        public String KeywordPrice
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.search.keyword.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_id" ,this.PlanId);
            paramters.Add("keyword_price" ,this.KeywordPrice);
        }

    }

}
