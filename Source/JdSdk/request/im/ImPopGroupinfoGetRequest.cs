﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Im;

namespace JdSdk.Request.Im
{
﻿    public class ImPopGroupinfoGetRequest : JdRequestBase<ImPopGroupinfoGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.im.pop.groupinfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
