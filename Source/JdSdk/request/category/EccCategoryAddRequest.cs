﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class EccCategoryAddRequest : JdRequestBase<EccCategoryAddResponse>
    {
        public Nullable<Int64> ParentCid
        {
            get;
            set;
        }

        public String CName
        {
            get;
            set;
        }

        public Nullable<Int32> HasLeaf
        {
            get;
            set;
        }

        public Nullable<Int32> Lev
        {
            get;
            set;
        }

        public Nullable<Int32> SortNumber
        {
            get;
            set;
        }

        public Nullable<Int32> HomeShow
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ecc.category.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("parent_cid" ,this.ParentCid);
            paramters.Add("c_name" ,this.CName);
            paramters.Add("has_leaf" ,this.HasLeaf);
            paramters.Add("lev" ,this.Lev);
            paramters.Add("sort_number" ,this.SortNumber);
            paramters.Add("home_show" ,this.HomeShow);
        }

    }

}
