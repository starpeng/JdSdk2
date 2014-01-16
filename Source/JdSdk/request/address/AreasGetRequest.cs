﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Address;

namespace JdSdk.Request.Address
{
﻿    public class AreasGetRequest : JdRequestBase<AreasGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.areas.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
