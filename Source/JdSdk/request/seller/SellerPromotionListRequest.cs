﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Seller;

namespace JdSdk.Request.Seller
{
﻿    public class SellerPromotionListRequest : JdRequestBase<SellerPromotionListResponse>
    {
        public Nullable<Int32> Type
        {
            get;
            set;
        }

        public Nullable<Int32> Status
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
            get{ return "jingdong.seller.promotion.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("type" ,this.Type);
            paramters.Add("status" ,this.Status);
            paramters.Add("page" ,this.Page);
            paramters.Add("size" ,this.Size);
        }

    }

}
