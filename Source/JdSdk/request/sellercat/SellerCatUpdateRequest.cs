﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Sellercat;

namespace JdSdk.Request.Sellercat
{
﻿    public class SellerCatUpdateRequest : JdRequestBase<SellerCatUpdateResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public String Name
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
            get{ return "360buy.sellercat.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("name" ,this.Name);
            paramters.Add("is_home_show" ,this.IsHomeShow);
        }

    }

}
