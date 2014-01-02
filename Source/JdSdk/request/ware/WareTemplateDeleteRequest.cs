﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareTemplateDeleteRequest : JdRequestBase<WareTemplateDeleteResponse>
    {
        public String Id
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
        }

    }

}
