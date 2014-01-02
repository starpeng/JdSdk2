﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Service;

namespace JdSdk.Request.Service
{
﻿    public class AfsserviceCategoryGetRequest : JdRequestBase<AfsserviceCategoryGetResponse>
    {
        public Nullable<Int32> AfsCategoryId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.afsservice.category.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("afsCategoryId" ,this.AfsCategoryId);
        }

    }

}
