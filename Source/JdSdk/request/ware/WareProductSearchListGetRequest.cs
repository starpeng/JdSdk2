﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareProductSearchListGetRequest : JdRequestBase<WareProductSearchListGetResponse>
    {
        public Nullable<Boolean> IsLoadAverageScore
        {
            get;
            set;
        }

        public Nullable<Boolean> IsLoadPromotion
        {
            get;
            set;
        }

        public Nullable<Int32> Sort
        {
            get;
            set;
        }

        public Nullable<Int32> Page
        {
            get;
            set;
        }

        public Nullable<Int32> PageSize
        {
            get;
            set;
        }

        public String Keyword
        {
            get;
            set;
        }

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.product.search.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("isLoadAverageScore" ,this.IsLoadAverageScore);
            paramters.Add("isLoadPromotion" ,this.IsLoadPromotion);
            paramters.Add("sort" ,this.Sort);
            paramters.Add("page" ,this.Page);
            paramters.Add("pageSize" ,this.PageSize);
            paramters.Add("keyword" ,this.Keyword);
            paramters.Add("client" ,this.Client);
        }

    }

}
