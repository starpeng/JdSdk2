﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class CategoryAttributeValueSearchRequest : JdRequestBase<CategoryAttributeValueSearchResponse>
    {
        public String Avs
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
            get{ return "360buy.ware.get.attvalue"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("avs" ,this.Avs);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
