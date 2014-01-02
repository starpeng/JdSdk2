﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Supplier;

namespace JdSdk.Request.Supplier
{
﻿    public class PopVenderCenerVenderBrandQueryRequest : JdRequestBase<PopVenderCenerVenderBrandQueryResponse>
    {
        public String Name
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.pop.vender.cener.venderBrand.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("name" ,this.Name);
        }

    }

}
