﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class VcStockSalesGetRequest : JdRequestBase<VcStockSalesGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.vc.stock.sales.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

    }

}
