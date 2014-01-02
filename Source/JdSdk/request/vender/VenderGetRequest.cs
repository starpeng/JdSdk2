﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Vender;

namespace JdSdk.Request.Vender
{
﻿    public class VenderGetRequest : JdRequestBase<VenderGetResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.vender.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
        }

    }

}
