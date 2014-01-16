﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Udp;

namespace JdSdk.Request.Udp
{
﻿    public class DataserviceShopvistop15bydayGetRequest : JdRequestBase<DataserviceShopvistop15bydayGetResponse>
    {
        public String TimeId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dataservice.shopvistop15byday.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("timeId" ,this.TimeId);
        }

    }

}
