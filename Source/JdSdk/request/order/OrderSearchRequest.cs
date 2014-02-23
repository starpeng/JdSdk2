﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderSearchRequest : JdRequestBase<OrderSearchResponse>
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

        public String OrderState
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

        public String SortType
        {
            get;
            set;
        }

        public String DateType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("order_state" ,this.OrderState);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("optional_fields" ,this.OptionalFields);
            paramters.Add("sortType" ,this.SortType);
            paramters.Add("dateType" ,this.DateType);
        }

    }

}
