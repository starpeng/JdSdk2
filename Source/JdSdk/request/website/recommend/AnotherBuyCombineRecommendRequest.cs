﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Website.Recommend;

namespace JdSdk.Request.Website.Recommend
{
﻿    public class AnotherBuyCombineRecommendRequest : JdRequestBase<AnotherBuyCombineRecommendResponse>
    {
        public String WareId
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
            get{ return "jingdong.anotherbuyrecommend.ware.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("fields" ,this.Fields);
        }

    }

}
