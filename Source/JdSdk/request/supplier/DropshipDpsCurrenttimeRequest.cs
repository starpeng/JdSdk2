﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class DropshipDpsCurrenttimeRequest : JdRequestBase<DropshipDpsCurrenttimeResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.dropship.dps.currenttime"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
