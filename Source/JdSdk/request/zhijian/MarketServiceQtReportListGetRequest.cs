﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Zhijian;

namespace JdSdk.Request.Zhijian
{
﻿    public class MarketServiceQtReportListGetRequest : JdRequestBase<MarketServiceQtReportListGetResponse>
    {
        public String ServiceItemCode
        {
            get;
            set;
        }

        public Nullable<Int32> QtType
        {
            get;
            set;
        }

        public String SpName
        {
            get;
            set;
        }

        public String StartTime
        {
            get;
            set;
        }

        public String EndTime
        {
            get;
            set;
        }

        public String Pin
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.market.service.qt.report.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("service_item_code" ,this.ServiceItemCode);
            paramters.Add("qt_type" ,this.QtType);
            paramters.Add("sp_name" ,this.SpName);
            paramters.Add("start_time" ,this.StartTime);
            paramters.Add("end_time" ,this.EndTime);
            paramters.Add("pin" ,this.Pin);
        }

    }

}
