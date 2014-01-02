﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Delivery;

namespace JdSdk.Request.Delivery
{
﻿    public class DeliveryLogisticsGetRequest : JdRequestBase<DeliveryLogisticsGetResponse>
    {
        public String OptionalFields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.delivery.logistics.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("optional_fields" ,this.OptionalFields);
        }

    }

}
