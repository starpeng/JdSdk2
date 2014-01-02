﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Wms;

namespace JdSdk.Request.Wms
{
﻿    public class LogisticsSkuQueryRequest : JdRequestBase<LogisticsSkuQueryResponse>
    {
        public String JoslGoodNo
        {
            get;
            set;
        }

        public String IsvGoodNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.logistics.sku.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("josl_good_no" ,this.JoslGoodNo);
            paramters.Add("isv_good_no" ,this.IsvGoodNo);
        }

    }

}
