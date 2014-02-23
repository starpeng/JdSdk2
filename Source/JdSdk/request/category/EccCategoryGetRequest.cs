﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class EccCategoryGetRequest : JdRequestBase<EccCategoryGetResponse>
    {
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.category.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
        }

    }

}
