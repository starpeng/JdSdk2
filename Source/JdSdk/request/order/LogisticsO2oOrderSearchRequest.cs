﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class LogisticsO2oOrderSearchRequest : JdRequestBase<LogisticsO2oOrderSearchResponse>
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

        public String OrderState
        {
            get;
            set;
        }

        public String OrderTimeStart
        {
            get;
            set;
        }

        public String OrderTimeEnd
        {
            get;
            set;
        }

        public String OrderUpdateTimeStart
        {
            get;
            set;
        }

        public String OrderUpdateTimeEnd
        {
            get;
            set;
        }

        public Nullable<Int32> CurrentPage
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.o2o.order.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pin" ,this.Pin);
            paramters.Add("station_no" ,this.StationNo);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("order_state" ,this.OrderState);
            paramters.Add("order_time_start" ,this.OrderTimeStart);
            paramters.Add("order_time_end" ,this.OrderTimeEnd);
            paramters.Add("order_update_time_start" ,this.OrderUpdateTimeStart);
            paramters.Add("order_update_time_end" ,this.OrderUpdateTimeEnd);
            paramters.Add("current_page" ,this.CurrentPage);
        }

    }

}
