﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Workorder;

namespace JdSdk.Request.Workorder
{
﻿    public class WosWorkinfoGetRequest : JdRequestBase<WosWorkinfoGetResponse>
    {
        public Nullable<Int64> WorkId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.wos.workinfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("work_id" ,this.WorkId);
        }

    }

}
