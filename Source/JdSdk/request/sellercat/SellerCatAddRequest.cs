﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Sellercat;

namespace JdSdk.Request.Sellercat
{
﻿    public class SellerCatAddRequest : JdRequestBase<SellerCatAddResponse>
    {
        public String ParentId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public Nullable<Boolean> IsOpen
        {
            get;
            set;
        }

        public Nullable<Boolean> IsHomeShow
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sellercat.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("parent_id" ,this.ParentId);
            paramters.Add("name" ,this.Name);
            paramters.Add("is_open" ,this.IsOpen);
            paramters.Add("is_home_show" ,this.IsHomeShow);
        }

    }

}
