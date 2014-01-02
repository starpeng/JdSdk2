﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareBaseproductGetRequest : JdRequestBase<WareBaseproductGetResponse>
    {
        public String Ids
        {
            get;
            set;
        }

        public String Base
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.baseproduct.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ids" ,this.Ids);
            paramters.Add("base" ,this.Base);
        }

    }

}
