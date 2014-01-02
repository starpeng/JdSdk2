﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareTemplateToWaresUpdateRequest : JdRequestBase<WareTemplateToWaresUpdateResponse>
    {
        public String Id
        {
            get;
            set;
        }

        public String WareIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.to.wares.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("ware_ids" ,this.WareIds);
        }

    }

}
