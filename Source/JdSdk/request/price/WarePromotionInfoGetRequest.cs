﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Price;

namespace JdSdk.Request.Price
{
﻿    public class WarePromotionInfoGetRequest : JdRequestBase<WarePromotionInfoGetResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public Nullable<Int32> WebSite
        {
            get;
            set;
        }

        public Nullable<Int32> Origin
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.promotionInfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("webSite" ,this.WebSite);
            paramters.Add("origin" ,this.Origin);
        }

    }

}
