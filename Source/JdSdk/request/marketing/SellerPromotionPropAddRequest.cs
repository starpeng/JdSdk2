﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionPropAddRequest : JdRequestBase<SellerPromotionPropAddResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public String Type
        {
            get;
            set;
        }

        public String Num
        {
            get;
            set;
        }

        public String UsedWay
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.prop.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("type" ,this.Type);
            paramters.Add("num" ,this.Num);
            paramters.Add("used_way" ,this.UsedWay);
        }

    }

}
