﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Mobile;

namespace JdSdk.Request.Mobile
{
﻿    public class WareProductDetailSearchListGetRequest : JdRequestBase<WareProductDetailSearchListGetResponse>
    {
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        public Nullable<Boolean> IsLoadWareScore
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
            get{ return "jingdong.ware.product.detail.search.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("isLoadWareScore" ,this.IsLoadWareScore);
            paramters.Add("client" ,this.Client);
        }

    }

}
