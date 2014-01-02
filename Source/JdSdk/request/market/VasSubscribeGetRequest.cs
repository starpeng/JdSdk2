﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Market;

namespace JdSdk.Request.Market
{
﻿    public class VasSubscribeGetRequest : JdRequestBase<VasSubscribeGetResponse>
    {
        public String UserName
        {
            get;
            set;
        }

        public String ItemCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.vas.subscribe.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("user_name" ,this.UserName);
            paramters.Add("item_code" ,this.ItemCode);
        }

    }

}
