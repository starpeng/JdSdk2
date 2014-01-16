﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareProductStockListGetRequest : JdRequestBase<WareProductStockListGetResponse>
    {
        public Nullable<Int32> SkuId
        {
            get;
            set;
        }

        public Nullable<Int32> ProvinceId
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
            get{ return "jingdong.ware.product.stock.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("provinceId" ,this.ProvinceId);
            paramters.Add("client" ,this.Client);
        }

    }

}
