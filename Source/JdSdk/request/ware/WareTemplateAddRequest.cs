﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareTemplateAddRequest : JdRequestBase<WareTemplateAddResponse>
    {
        public String Name
        {
            get;
            set;
        }

        public String[] Contents
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("name" ,this.Name);
            paramters.Add("contents" ,this.Contents);
        }

    }

}
