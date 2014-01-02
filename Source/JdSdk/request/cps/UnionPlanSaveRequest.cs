﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPlanSaveRequest : JdRequestBase<UnionPlanSaveResponse>
    {
        public String PlanId
        {
            get;
            set;
        }

        public String PlanName
        {
            get;
            set;
        }

        public String StartDate
        {
            get;
            set;
        }

        public String EndDate
        {
            get;
            set;
        }

        public String Notes
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public String Category
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.plan.save"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("planId" ,this.PlanId);
            paramters.Add("planName" ,this.PlanName);
            paramters.Add("startDate" ,this.StartDate);
            paramters.Add("endDate" ,this.EndDate);
            paramters.Add("notes" ,this.Notes);
            paramters.Add("status" ,this.Status);
            paramters.Add("category" ,this.Category);
        }

    }

}
