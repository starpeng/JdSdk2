﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class EccCategoryChildsListGetRequest : JdRequestBase<EccCategoryChildsListGetResponse>
    {
        public Nullable<Int64> Pid
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.category.childs.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("pid" ,this.Pid);
        }

    }

}
