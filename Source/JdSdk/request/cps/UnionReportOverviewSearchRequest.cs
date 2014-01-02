﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionReportOverviewSearchRequest : JdRequestBase<UnionReportOverviewSearchResponse>
    {
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

        public override String ApiName
        {
            get{ return "jingdong.union.report.overview.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
        }

    }

}
