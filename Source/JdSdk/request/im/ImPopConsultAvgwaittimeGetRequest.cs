﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Im;

namespace JdSdk.Request.Im
{
﻿    public class ImPopConsultAvgwaittimeGetRequest : JdRequestBase<ImPopConsultAvgwaittimeGetResponse>
    {
        public String Waiter
        {
            get;
            set;
        }

        public Nullable<DateTime> Date
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.im.pop.consult.avgwaittime.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waiter" ,this.Waiter);
            paramters.Add("date" ,this.Date);
        }

    }

}
