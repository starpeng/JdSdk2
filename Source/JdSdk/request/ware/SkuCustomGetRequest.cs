﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class SkuCustomGetRequest : JdRequestBase<SkuCustomGetResponse>
    {
        public String OuterId
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sku.custom.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("outer_id" ,this.OuterId);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
