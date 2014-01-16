﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionOrdermodeAddRequest : JdRequestBase<SellerPromotionOrdermodeAddResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public Nullable<Int32> FavorMode
        {
            get;
            set;
        }

        public String Quota
        {
            get;
            set;
        }

        public String Rate
        {
            get;
            set;
        }

        public String Plus
        {
            get;
            set;
        }

        public String Minus
        {
            get;
            set;
        }

        public String Link
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.ordermode.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("favor_mode" ,this.FavorMode);
            paramters.Add("quota" ,this.Quota);
            paramters.Add("rate" ,this.Rate);
            paramters.Add("plus" ,this.Plus);
            paramters.Add("minus" ,this.Minus);
            paramters.Add("link" ,this.Link);
        }

    }

}
