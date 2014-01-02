﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Seller;

namespace JdSdk.Request.Seller
{
﻿    public class SellerPromotionCommitRequest : JdRequestBase<SellerPromotionCommitResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.commit"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
        }

    }

}
