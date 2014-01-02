﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Workorder;

namespace JdSdk.Request.Workorder
{
﻿    public class WosWorklistGetRequest : JdRequestBase<WosWorklistGetResponse>
    {
        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public Nullable<Int64> OrderId
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

        public Nullable<Int32> PageNumber
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
            get{ return "jingdong.wos.worklist.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("status" ,this.Status);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("begin_date" ,this.BeginDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page_number" ,this.PageNumber);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
