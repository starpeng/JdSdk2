﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Price;

namespace JdSdk.Request.Price
{
﻿    public class WarePriceGetRequest : JdRequestBase<WarePriceGetResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.price.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("sku_id" ,this.SkuId);
        }

    }

}
