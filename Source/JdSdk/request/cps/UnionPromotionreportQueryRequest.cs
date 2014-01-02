﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPromotionreportQueryRequest : JdRequestBase<UnionPromotionreportQueryResponse>
    {
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.promotionreport.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("startDate" ,this.StartDate);
            paramters.Add("endDate" ,this.EndDate);
            paramters.Add("pageIndex" ,this.PageIndex);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
