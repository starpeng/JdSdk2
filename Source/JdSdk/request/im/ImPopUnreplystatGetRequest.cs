﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Im;

namespace JdSdk.Request.Im
{
﻿    public class ImPopUnreplystatGetRequest : JdRequestBase<ImPopUnreplystatGetResponse>
    {
        public String Waiter
        {
            get;
            set;
        }

        public Nullable<DateTime> StartTime
        {
            get;
            set;
        }

        public Nullable<DateTime> EndTime
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.im.pop.unreplystat.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waiter" ,this.Waiter);
            paramters.Add("startTime" ,this.StartTime);
            paramters.Add("endTime" ,this.EndTime);
        }

    }

}
