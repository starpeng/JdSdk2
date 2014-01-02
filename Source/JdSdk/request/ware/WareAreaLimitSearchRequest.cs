﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareAreaLimitSearchRequest : JdRequestBase<WareAreaLimitSearchResponse>
    {
        public String WareId
        {
            get;
            set;
        }

        public String Type
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
            get{ return "360buy.ware.area.limit.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("type" ,this.Type);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
