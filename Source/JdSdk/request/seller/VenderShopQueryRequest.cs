﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Seller;

namespace JdSdk.Request.Seller
{
﻿    public class VenderShopQueryRequest : JdRequestBase<VenderShopQueryResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.vender.shop.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
