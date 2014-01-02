﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Sellercat;

namespace JdSdk.Request.Sellercat
{
﻿    public class SellerCatsGetRequest : JdRequestBase<SellerCatsGetResponse>
    {
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sellercats.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("fields" ,this.Fields);
        }

    }

}
