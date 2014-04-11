﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Ware;

namespace JdSdk.Request.Ware
{
﻿    public class WareAddVenderSellSkuRequest : JdRequestBase<WareAddVenderSellSkuResponse>
    {
        public String CategoryId
        {
            get;
            set;
        }

        public String IndexId
        {
            get;
            set;
        }

        public String AttributeId
        {
            get;
            set;
        }

        public String AttributeValue
        {
            get;
            set;
        }

        public String Features
        {
            get;
            set;
        }

        public String Status
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.wares.vendersellsku.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("category_id" ,this.CategoryId);
            paramters.Add("index_id" ,this.IndexId);
            paramters.Add("attribute_id" ,this.AttributeId);
            paramters.Add("attribute_value" ,this.AttributeValue);
            paramters.Add("features" ,this.Features);
            paramters.Add("status" ,this.Status);
        }

    }

}
