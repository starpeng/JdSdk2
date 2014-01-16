﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionActivitymodeAddRequest : JdRequestBase<SellerPromotionActivitymodeAddResponse>
    {
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public Nullable<Int32> NumBound
        {
            get;
            set;
        }

        public Nullable<Int32> FreqBound
        {
            get;
            set;
        }

        public Nullable<Int32> PerMaxNum
        {
            get;
            set;
        }

        public Nullable<Int32> PerMinNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.activitymode.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("num_bound" ,this.NumBound);
            paramters.Add("freq_bound" ,this.FreqBound);
            paramters.Add("per_max_num" ,this.PerMaxNum);
            paramters.Add("per_min_num" ,this.PerMinNum);
        }

    }

}
