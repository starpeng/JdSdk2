﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Website.Response;
using JdSdk.Request;
using JdSdk.Domain.Website.Response;

namespace JdSdk.Domain.Website.Request
{
﻿    public class OrderCanBuyTownRequest : JdRequestBase<OrderCanBuyTownResponse>
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

        public String AreaId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.order.support.town"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("skus_info" ,this.SkusInfo);
            paramters.Add("buyer_name" ,this.BuyerName);
            paramters.Add("area_id" ,this.AreaId);
        }

    }

}
