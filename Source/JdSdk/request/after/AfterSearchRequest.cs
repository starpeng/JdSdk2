﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.After;

namespace JdSdk.Request.After
{
﻿    public class AfterSearchRequest : JdRequestBase<AfterSearchResponse>
    {
        public List<Field> QueryFields
        {
            get;
            set;
        }

        public String SelectFields
        {
            get;
            set;
        }

        public String Page
        {
            get;
            set;
        }

        public String PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.after.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("query_fields" ,this.QueryFields);
            paramters.Add("select_fields" ,this.SelectFields);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
        }

    }

}
