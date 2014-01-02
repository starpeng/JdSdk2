﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Sellercat;

namespace JdSdk.Request.Sellercat
{
﻿    public class SellerCatDeleteRequest : JdRequestBase<SellerCatDeleteResponse>
    {
        public String Cid
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sellercat.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
        }

    }

}
