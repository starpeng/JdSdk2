﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class VcStockSalesDetailGetRequest : JdRequestBase<VcStockSalesDetailGetResponse>
    {
        public String ProductCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.vc.stock.sales.detail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("product_code" ,this.ProductCode);
        }

    }

}
