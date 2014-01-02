﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Category;

namespace JdSdk.Request.Website.Category
{
﻿    public class WareAttributesGetRequest : JdRequestBase<WareAttributesGetResponse>
    {
        public String Cid
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
            get{ return "jingdong.wareattributes.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
