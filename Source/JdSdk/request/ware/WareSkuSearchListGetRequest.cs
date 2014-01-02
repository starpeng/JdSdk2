﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareSkuSearchListGetRequest : JdRequestBase<WareSkuSearchListGetResponse>
    {
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.sku.search.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("client" ,this.Client);
        }

    }

}
