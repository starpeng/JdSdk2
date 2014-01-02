﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderFbpSearchRequest : JdRequestBase<OrderFbpSearchResponse>
    {
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

        public String Page
        {
            get;
            set;
        }

        public String PageSize
        {
            get;
            set;
        }

        public String OptionalFields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.fbp.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("optional_fields" ,this.OptionalFields);
        }

    }

}
