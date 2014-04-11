﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Zhijian;

namespace JdSdk.Request.Zhijian
{
﻿    public class MarketServiceQtSubscribeGetRequest : JdRequestBase<MarketServiceQtSubscribeGetResponse>
    {
        public String ServiceItemCode
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
            get{ return "jingdong.market.service.qt.subscribe.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("service_item_code" ,this.ServiceItemCode);
            paramters.Add("pin" ,this.Pin);
        }

    }

}
