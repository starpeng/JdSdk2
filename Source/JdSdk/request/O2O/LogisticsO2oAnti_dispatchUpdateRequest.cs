﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.O2O;

namespace JdSdk.Request.O2O
{
﻿    public class LogisticsO2oAntiDispatchUpdateRequest : JdRequestBase<LogisticsO2oAntiDispatchUpdateResponse>
    {
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

        public String StateOperator
        {
            get;
            set;
        }

        public String RealShop
        {
            get;
            set;
        }

        public String AntiDispatcherRemark
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.o2o.anti_dispatch.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("station_no" ,this.StationNo);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("state_operator" ,this.StateOperator);
            paramters.Add("real_shop" ,this.RealShop);
            paramters.Add("anti_dispatcher_remark" ,this.AntiDispatcherRemark);
        }

    }

}
