﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class LogisticsO2oOrderQueryAfsRequest : JdRequestBase<LogisticsO2oOrderQueryAfsResponse>
    {
        public String Pin
        {
            get;
            set;
        }

        public String StationNo
        {
            get;
            set;
        }

        public String OrderId
        {
            get;
            set;
        }

        public String CustomerOrderId
        {
            get;
            set;
        }

        public String CustomerOrderState
        {
            get;
            set;
        }

        public String CustomerOrderTimeStart
        {
            get;
            set;
        }

        public String CustomerOrderTimeEnd
        {
            get;
            set;
        }

        public String CustomerOrderUpdateTimeStart
        {
            get;
            set;
        }

        public String CustomerOrderUpdateTimeEnd
        {
            get;
            set;
        }

        public Nullable<Int32> CurrentPage
        {
            get;
            set;
        }

        public Nullable<Int32> PageNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.o2o.order.queryAfs"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pin" ,this.Pin);
            paramters.Add("station_no" ,this.StationNo);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("customer_order_id" ,this.CustomerOrderId);
            paramters.Add("customer_order_state" ,this.CustomerOrderState);
            paramters.Add("customer_order_time_start" ,this.CustomerOrderTimeStart);
            paramters.Add("customer_order_time_end" ,this.CustomerOrderTimeEnd);
            paramters.Add("customer_order_update_time_start" ,this.CustomerOrderUpdateTimeStart);
            paramters.Add("customer_order_update_time_end" ,this.CustomerOrderUpdateTimeEnd);
            paramters.Add("current_page" ,this.CurrentPage);
            paramters.Add("page_num" ,this.PageNum);
        }

    }

}
