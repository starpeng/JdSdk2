﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class CategoryGroupSearchRequest : JdRequestBase<CategoryGroupSearchResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public String Cid
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.groups.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
            paramters.Add("cid" ,this.Cid);
        }

    }

}
