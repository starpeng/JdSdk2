﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Response;
using JdSdk.Request;

namespace JdSdk.Domain.Website.Request
{
﻿    public class OrderCanBuyAreaRequest : JdRequestBase<OrderCanBuyAreaResponse>
    {
        public String SkusInfo
        {
            get;
            set;
        }

        public String BuyerName
        {
            get;
            set;
        }

        public String CityId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.support.area"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skus_info" ,this.SkusInfo);
            paramters.Add("buyer_name" ,this.BuyerName);
            paramters.Add("city_id" ,this.CityId);
        }

    }

}
