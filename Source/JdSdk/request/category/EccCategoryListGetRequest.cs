﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class EccCategoryListGetRequest : JdRequestBase<EccCategoryListGetResponse>
    {
        public Nullable<Int64> ParentCid
        {
            get;
            set;
        }

        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public Nullable<Int32> Lev
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.category.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("parent_cid" ,this.ParentCid);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("status" ,this.Status);
            paramters.Add("lev" ,this.Lev);
        }

    }

}
