﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheAccountGetRequest : JdRequestBase<KuaicheAccountGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.kuaiche.account.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
