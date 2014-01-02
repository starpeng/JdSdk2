﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsSearchpreRequest : JdRequestBase<DropshipDpsSearchpreResponse>
    {
        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public Nullable<Int32> Page
        {
            get;
            set;
        }

        public Nullable<DateTime> BeginDate
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
            get{ return "jingdong.dropship.dps.searchpre"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("page" ,this.Page);
            paramters.Add("beginDate" ,this.BeginDate);
            paramters.Add("endDate" ,this.EndDate);
        }

    }

}
