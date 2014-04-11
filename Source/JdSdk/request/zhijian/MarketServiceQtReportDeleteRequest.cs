﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Zhijian;

namespace JdSdk.Request.Zhijian
{
﻿    public class MarketServiceQtReportDeleteRequest : JdRequestBase<MarketServiceQtReportDeleteResponse>
    {
        public String QtCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.market.service.qt.report.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("qtCode" ,this.QtCode);
        }

    }

}
