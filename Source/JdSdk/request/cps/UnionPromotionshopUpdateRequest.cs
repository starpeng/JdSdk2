﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPromotionshopUpdateRequest : JdRequestBase<UnionPromotionshopUpdateResponse>
    {
        public String ShopName
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.promotionshop.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("shopName" ,this.ShopName);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
