﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Address;

namespace JdSdk.Request.Address
{
﻿    public class AreaIpQueryRequest : JdRequestBase<AreaIpQueryResponse>
    {
        public String Ip
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.area.ip.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ip" ,this.Ip);
        }

    }

}
