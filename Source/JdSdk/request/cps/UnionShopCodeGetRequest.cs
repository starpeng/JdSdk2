﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionShopCodeGetRequest : JdRequestBase<UnionShopCodeGetResponse>
    {
        public Nullable<Int64> ShopId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.shop.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("shop_id" ,this.ShopId);
        }

    }

}
