﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnKeywordgroupListSearchRequest : JdRequestBase<KuaicheZnKeywordgroupListSearchResponse>
    {
        public Nullable<Int64> ThirdCategoryId
        {
            get;
            set;
        }

        public String SortField
        {
            get;
            set;
        }

        public Nullable<Int32> SortType
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public Nullable<Int32> PageIndex
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.keywordgroup.list.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("third_category_id" ,this.ThirdCategoryId);
            paramters.Add("sort_field" ,this.SortField);
            paramters.Add("sort_type" ,this.SortType);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("page_index" ,this.PageIndex);
        }

    }

}
