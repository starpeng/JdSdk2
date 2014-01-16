﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Marketing;

namespace JdSdk.Request.Marketing
{
﻿    public class SellerPromotionSkuListRequest : JdRequestBase<SellerPromotionSkuListResponse>
    {
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        public Nullable<Int32> BindType
        {
            get;
            set;
        }

        public Nullable<Int32> Page
        {
            get;
            set;
        }

        public Nullable<Int32> Size
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.sku.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("bind_type" ,this.BindType);
            paramters.Add("page" ,this.Page);
            paramters.Add("size" ,this.Size);
        }

    }

}
