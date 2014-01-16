﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionCheckRequest : JdRequestBase<SellerPromotionCheckResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public Nullable<Int32> Status
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.check"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("status" ,this.Status);
        }

    }

}
