﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Udp;

namespace JdSdk.Request.Udp
{
﻿    public class DataserviceFwlistpvGetRequest : JdRequestBase<DataserviceFwlistpvGetResponse>
    {
        public String Url
        {
            get;
            set;
        }

        public String StatDt
        {
            get;
            set;
        }

        public String EndDt
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.dataservice.fwlistpv.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("url" ,this.Url);
            paramters.Add("stat_dt" ,this.StatDt);
            paramters.Add("end_dt" ,this.EndDt);
        }

    }

}
