﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class UserCategory3InfoGetRequest : JdRequestBase<UserCategory3InfoGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.userCategory3.info.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
