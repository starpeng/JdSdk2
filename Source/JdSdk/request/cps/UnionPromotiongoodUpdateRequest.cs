﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionPromotiongoodUpdateRequest : JdRequestBase<UnionPromotiongoodUpdateResponse>
    {
        public String SkuId
        {
            get;
            set;
        }

        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.promotiongood.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skuId" ,this.SkuId);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
