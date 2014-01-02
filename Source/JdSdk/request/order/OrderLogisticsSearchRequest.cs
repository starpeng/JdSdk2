﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OrderLogisticsSearchRequest : JdRequestBase<OrderLogisticsSearchResponse>
    {
        public String VenderId
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

        public override String ApiName
        {
            get{ return "jingdong.logistics.orders.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("vender_id" ,this.VenderId);
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
