﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceMajorcategoryGetRequest : JdRequestBase<AfsserviceMajorcategoryGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.majorcategory.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
