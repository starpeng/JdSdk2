﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionSkuAddRequest : JdRequestBase<SellerPromotionSkuAddResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public String SkuIds
        {
            get;
            set;
        }

        public String JdPrices
        {
            get;
            set;
        }

        public String PromoPrices
        {
            get;
            set;
        }

        public String Seq
        {
            get;
            set;
        }

        public String Num
        {
            get;
            set;
        }

        public String BindType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.sku.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("sku_ids" ,this.SkuIds);
            paramters.Add("jd_prices" ,this.JdPrices);
            paramters.Add("promo_prices" ,this.PromoPrices);
            paramters.Add("seq" ,this.Seq);
            paramters.Add("num" ,this.Num);
            paramters.Add("bind_type" ,this.BindType);
        }

    }

}
