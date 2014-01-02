﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Ware;

namespace JdSdk.Request.Website.Ware
{
﻿    public class SkuJdPriceGetRequest : JdRequestBase<SkuJdPriceGetResponse>
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
            get{ return "jingdong.sku.jdprice.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("website" ,this.WebSite);
            paramters.Add("origin" ,this.Origin);
        }

    }

}
