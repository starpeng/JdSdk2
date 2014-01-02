﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionMasterAccountGetRequest : JdRequestBase<UnionMasterAccountGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.union.master.account.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
