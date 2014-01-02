﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnPlanListSearchRequest : JdRequestBase<KuaicheZnPlanListSearchResponse>
    {
        public String PlanName
        {
            get;
            set;
        }

        public String Mode
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public String IsQueryByStatus
        {
            get;
            set;
        }

        public Nullable<Int32> Begin
        {
            get;
            set;
        }

        public Nullable<Int32> End
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.list.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_name" ,this.PlanName);
            paramters.Add("mode" ,this.Mode);
            paramters.Add("status" ,this.Status);
            paramters.Add("is_query_by_status" ,this.IsQueryByStatus);
            paramters.Add("begin" ,this.Begin);
            paramters.Add("end" ,this.End);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("page_index" ,this.PageIndex);
        }

    }

}
