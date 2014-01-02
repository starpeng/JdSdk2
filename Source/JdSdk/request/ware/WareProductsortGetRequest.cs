﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareProductsortGetRequest : JdRequestBase<WareProductsortGetResponse>
    {
        public String ProductSortIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.productsort.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("product_sort_ids" ,this.ProductSortIds);
        }

    }

}
