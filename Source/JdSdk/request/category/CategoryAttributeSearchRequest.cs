﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class CategoryAttributeSearchRequest : JdRequestBase<CategoryAttributeSearchResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public String IsKeyProp
        {
            get;
            set;
        }

        public String IsSaleProp
        {
            get;
            set;
        }

        public String Aid
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
            get{ return "360buy.ware.get.attribute"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("is_key_prop" ,this.IsKeyProp);
            paramters.Add("is_sale_prop" ,this.IsSaleProp);
            paramters.Add("aid" ,this.Aid);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
