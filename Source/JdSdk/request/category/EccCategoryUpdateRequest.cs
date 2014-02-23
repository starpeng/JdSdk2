﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Category;

namespace JdSdk.Request.Category
{
﻿    public class EccCategoryUpdateRequest : JdRequestBase<EccCategoryUpdateResponse>
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

        public String CName
        {
            get;
            set;
        }

        public Nullable<Int32> SortNumber
        {
            get;
            set;
        }

        public Nullable<Int32> Lev
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
            get{ return "jingdong.ecc.category.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("parent_cid" ,this.ParentCid);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("c_name" ,this.CName);
            paramters.Add("sort_number" ,this.SortNumber);
            paramters.Add("lev" ,this.Lev);
            paramters.Add("home_show" ,this.HomeShow);
        }

    }

}
