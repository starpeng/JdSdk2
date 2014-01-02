﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Category;

namespace JdSdk.Request.Website.Category
{
﻿    public class WareCategoryGetRequest : JdRequestBase<WareCategoryGetResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public String Level
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
            get{ return "jingdong.warecategory.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("level" ,this.Level);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
