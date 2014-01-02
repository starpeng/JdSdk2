﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPromotionactivityQueryRequest : JdRequestBase<UnionPromotionactivityQueryResponse>
    {
        public String Keywords
        {
            get;
            set;
        }

        public Nullable<Int64> CategoryId
        {
            get;
            set;
        }

        public String Property
        {
            get;
            set;
        }

        public String Sort
        {
            get;
            set;
        }

        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        public Nullable<Int64> PageSize
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
            get{ return "jingdong.union.promotionactivity.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("keywords" ,this.Keywords);
            paramters.Add("categoryId" ,this.CategoryId);
            paramters.Add("property" ,this.Property);
            paramters.Add("sort" ,this.Sort);
            paramters.Add("pageIndex" ,this.PageIndex);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
